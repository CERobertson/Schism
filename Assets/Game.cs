using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {
    public static Game Instance { get; private set; }
    public ActionMap InputState;
    ActionMap previousInputState;
    void Awake() {
        if (Instance == null) {
            _inputActions = new InputActions();
            _inputActionDictionary = new Dictionary<Type, PropertyInfo>();
            _inputActionEnabledDictionary = new Dictionary<Type, PropertyInfo>(); ;
            _inputActionEnableDictionary = new Dictionary<Type, MethodInfo>(); ;
            _inputActionDisableDictionary = new Dictionary<Type, MethodInfo>(); ;
            GenerateInputActionDictionary();
            Instance = this;
        }
        else
            Debug.LogWarning($"Only one instance of {typeof(Game)} expected.");
    }
    void Update() {
        if (previousInputState != InputState) {
            foreach (var toToggle in (previousInputState ^ InputState).Decompose()) {
                if (InputControl.Instance.TryGetActionMapType(toToggle, out Type actionMapType)) {
                    if (Toggle(actionMapType) == null)
                        Debug.LogWarning($"'{actionMapType.Name}' not found in the Game Input Action Map Dictionary.");
                }
                else
                    Debug.LogWarning($"'{toToggle}' not found in the Input Control Id to Action Map Dictionary.");
                previousInputState ^= toToggle;
            }
        }
    }

    InputActions _inputActions;
    IDictionary<Type, PropertyInfo> _inputActionDictionary;
    IDictionary<Type, PropertyInfo> _inputActionEnabledDictionary;
    IDictionary<Type, MethodInfo> _inputActionEnableDictionary;
    IDictionary<Type, MethodInfo> _inputActionDisableDictionary;
    void GenerateInputActionDictionary() {
        foreach (var property in typeof(InputActions).GetProperties().Where(x => x.PropertyType.Name.Contains("Action") && x.Name != "asset")) {
            PropertyInfo propertyInfo;
            if (_inputActionDictionary.TryGetValue(property.PropertyType, out propertyInfo))
                Debug.LogWarning($"Action Map of type '{propertyInfo.PropertyType}' has already been inserted into the dictionary. Check InputActions definitions.");
            else {
                _inputActionDictionary[property.PropertyType] = property;
                _inputActionEnabledDictionary[property.PropertyType] = property.PropertyType.GetProperty("enabled");
                _inputActionEnableDictionary[property.PropertyType] = property.PropertyType.GetMethod("Enable");
                _inputActionDisableDictionary[property.PropertyType] = property.PropertyType.GetMethod("Disable");
                InputControl.Instance.Register(property.PropertyType);
            }
        }
    }
    bool TryResolveActionMap<T>(out T value) where T : class {
        value = null;
        if (_inputActionDictionary.TryGetValue(typeof(T), out PropertyInfo propertyInfo)) {
            value = propertyInfo.GetValue(_inputActions) as T;
            return true;
        }
        return false;
    }

    /// <summary>
    /// Caller can expect null results if the
    /// request for a type of ActionMap is
    /// made at an inappropriate time for the
    /// game or if a type other than an ActionMap
    /// is requested.
    /// </summary>
    /// <typeparam name="T">The type of action map requested</typeparam>
    /// <returns>The action map object requested, null when inaccessiable or not found.</returns>
    public T RequestActionMap<T>() where T : class {
        T result = null;
        if (InputControl.Instance.TryGetId<T>(out ActionMap actionMap)) {
            if (TryResolveActionMap(out result)) {
                if (InputState.AllowAddition(actionMap))
                    InputState |= actionMap;
                else
                    result = null;
            }
            else
                Debug.LogWarning($"'{typeof(T).Name}' not found in the Game Input Action Map Dictionary.");
        }
        else
            Debug.LogWarning($"'{typeof(T).Name}' not found in the InputControl Input Action Map Dictionary.");

        return result;
    }
    bool ActionMapGetEnabled(Type t, object o) => ((bool)_inputActionEnabledDictionary[t].GetValue(o));
    bool ActionMapSetEnabled(Type t, object o, bool value) {
        if (value)
            _inputActionEnableDictionary[t].Invoke(o, null);
        else
            _inputActionDisableDictionary[t].Invoke(o, null);
        return value;
    }
    bool? Toggle(Type t){
        if (_inputActionDictionary.TryGetValue(t, out PropertyInfo propertyInfo)) {
            var actionMap = propertyInfo.GetValue(_inputActions);
            return ActionMapGetEnabled(t, actionMap) ? ActionMapSetEnabled(t, actionMap, false) : ActionMapSetEnabled(t, actionMap, true);
        }
        return null;
    }

    Scene _currentScene;
    Scene _previousScene;
    public Scene CurrentScene {
        get => _currentScene;
        set {
            LoadedScenes.Add(value.SceneBuildIndex);
            DontDestroyOnLoad(value.LoadingScreen);
            LoadComplete += DestroyLoadingScreenOnLoadComplete;
            _currentScene = value;
        }
    }
    void DestroyLoadingScreenOnLoadComplete(object context, IList<AsyncOperation> eventArgs) {
        var game = context as Game;
        if (game != null) {
            Destroy(game._previousScene.LoadingScreen.gameObject);
            LoadComplete -= DestroyLoadingScreenOnLoadComplete;
        }
    }
    public void Load(int scene) {
        _previousScene = _currentScene;
        CurrentScene.LoadingScreen.Panel.SetActive(true);
        AddScene(scene);
        UnloadScene(_currentScene.SceneBuildIndex);
        StartCoroutine(GetSceneLoadProgress());
    }
    IList<AsyncOperation> ScenesLoading = new List<AsyncOperation>();
    IList<int> LoadedScenes = new List<int>();
    public void AddScene(int scene) {
        ScenesLoading.Add(SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive));
        LoadedScenes.Add(scene);
    }
    public void UnloadScene(int scene) {
        ScenesLoading.Add(SceneManager.UnloadSceneAsync((int)scene));
    }
    public IEnumerator GetSceneLoadProgress() {
        var finished = false;
        while (!finished) {
            finished = ScenesLoading.Aggregate(true, (accum, x) => accum &= x.isDone);
            yield return new WaitForEndOfFrame();
        }
        LoadComplete?.Invoke(this, ScenesLoading);
    }
    public event EventHandler<IList<AsyncOperation>> LoadComplete;
}
