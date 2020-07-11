using UnityEngine;
using UnityEngine.InputSystem;
using static InputActions;

public class ExclusionaryDisjunction : MonoBehaviour, IMenuOneDimensionalActions
{
    public string[] Options = new string[2];

    MenuOneDimensionalActions? _actions;

    public void OnNewaction(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    void Awake() {
        _actions = Game.Instance.RequestActionMap<MenuOneDimensionalActions>();
        if (_actions.HasValue)
            _actions.Value.SetCallbacks(this);
    }

}
