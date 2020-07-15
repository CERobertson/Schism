using System;
using System.Reflection;
using UnityEngine;

public abstract class ImplementsActionMap<T> : MonoBehaviour where T : struct {
    Action DisableInputActions;
    protected abstract void AwakeCallback();
    void Awake() {
        SetCallbacksMethod = typeof(T).GetMethod("SetCallbacks");
        AwakeCallback();
    }

    public event EventHandler<T?> OnEnableCallback;
    void OnEnable() {
        var _actions = Game.Instance.RequestActionMap<T>();
        if (_actions.HasValue) {
            SetCallbacks(_actions.Value, this);
            DisableInputActions = () => {
                SetCallbacks(_actions.Value, null);
                Game.Instance.DisableActionMap<T>();
            };
        }
        else
            enabled = false;
        OnEnableCallback?.Invoke(this, _actions);
    }
    public event EventHandler<T?> OnDisableCallback;
    void OnDisable() {
        DisableInputActions?.Invoke();
        OnDisableCallback?.Invoke(this, null);
    }
    MethodInfo SetCallbacksMethod;
    void SetCallbacks(T actionMap, object callbacks) =>
        SetCallbacksMethod.Invoke(actionMap, new object[] { callbacks });
}
