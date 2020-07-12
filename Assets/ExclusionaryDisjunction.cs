using System;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using static InputActions;

public abstract class ExclusionaryDisjunction : MonoBehaviour, IOneDimensionActions {
    public string[] Options = new string[2];
    Image[] OptionBackgrounds;

    void Awake() {
        OptionBackgrounds = new Image[Options.Length];
        for (int i=0; i<Options.Length; i++) {
            OptionBackgrounds[i] = gameObject.GetComponentsInChildren<Image>().Single(x => x.gameObject.name == Options[i]);
        }
    }

    void OnEnable() {
        index = 0;
        OptionBackgrounds[index].enabled = true;
        var _actions = Game.Instance.RequestActionMap<OneDimensionActions>();
        if (_actions.HasValue) {
            _actions.Value.SetCallbacks(this);
            DisableInputActions = () => {
                _actions.Value.SetCallbacks(null);
                Game.Instance.DisableActionMap<OneDimensionActions>();
            };
        }
    }

    int index;
    object _index_ = new object();
    public void OnPositive(InputAction.CallbackContext context) {
        lock (_index_) {
            if (context.phase == InputActionPhase.Started) {
                OptionBackgrounds[index].enabled = false;
                index = (index + 1) % Options.Length;
                OptionBackgrounds[index].enabled = true;
            }
        }
    }

    public void OnNegative(InputAction.CallbackContext context) {
        lock (_index_) {
            if (context.phase == InputActionPhase.Started) {
                OptionBackgrounds[index].enabled = false;
                index = (index - 1) < 0 ? Options.Length - 1 : (index - 1) % Options.Length;
                OptionBackgrounds[index].enabled = true;
            }
        }
    }

    public abstract void Confirm(int index);
    public void OnConfirm(InputAction.CallbackContext context) {
        lock (_index_) {
            DisableInputActions();
            Confirm(index);
        }
    }
    Action DisableInputActions;

    public abstract void Cancel();
    public void OnCancel(InputAction.CallbackContext context) {
        DisableInputActions();
        Cancel();
        gameObject.SetActive(false);
    }
}
