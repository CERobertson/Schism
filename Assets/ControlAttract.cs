using System;
using UnityEngine;
using UnityEngine.InputSystem;
using static InputActions;

public class ControlAttract : MonoBehaviour, IAnyActions {
    Action DisableInputActions;
    void OnEnable() {
        var _actions = Game.Instance.RequestActionMap<AnyActions>();
        if (_actions.HasValue) {
            _actions.Value.SetCallbacks(this);
            DisableInputActions = () => {
                _actions.Value.SetCallbacks(null);
                Game.Instance.DisableActionMap<AnyActions>();
            };
        }
    }
    public GameObject MenuQuickstart;
    public void OnPress(InputAction.CallbackContext context) {
        DisableInputActions();
        MenuQuickstart.SetActive(true);
        gameObject.SetActive(false);
    }
}
