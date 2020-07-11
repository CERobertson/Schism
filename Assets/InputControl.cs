using System;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour {
    public static InputControl Instance { get; private set; }
    void Awake() {
        if (Instance == null) {
            Instance = this;
            _actionMapIdDictionary = new Dictionary<Type, ActionMap>();
            _idActionMapDictionary = new Dictionary<ActionMap, Type>();
            _actionMapIndex_max = 32;
        }
        else
            Debug.LogWarning($"Only one instance of {typeof(InputControl)} expected.");
    }

    int _actionMapIndex = 0;
    int _actionMapIndex_max;
    IDictionary<Type, ActionMap> _actionMapIdDictionary;
    IDictionary<ActionMap, Type> _idActionMapDictionary;
    public bool TryRegister(Type t) {
        if (_actionMapIndex >= _actionMapIndex_max) {
            Debug.LogWarning($"Exceeded _actionMapIndex_max: '{_actionMapIndex_max}'. Registration skipped.");
            return false;
        }
        else if (!_actionMapIdDictionary.ContainsKey(t)) {
            var actionMap = (ActionMap)(1 << _actionMapIndex);
            _actionMapIdDictionary[t] = actionMap;
            _idActionMapDictionary[actionMap] = t;
            _actionMapIndex++;
        }
        return true;
    }
    public void Register(Type t) => TryRegister(t);

    public bool TryGetId<T>(out ActionMap id) => _actionMapIdDictionary.TryGetValue(typeof(T), out id);
    public ActionMap GetId<T>() { TryGetId<T>(out ActionMap id); return id; }
    public bool TryGetActionMapType(ActionMap actionMap, out Type t) => _idActionMapDictionary.TryGetValue(actionMap, out t);
    public Type GetActionMapType(ActionMap actionMap) { TryGetActionMapType(actionMap, out Type t); return t; }
}
