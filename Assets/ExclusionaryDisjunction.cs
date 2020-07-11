using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using static InputActions;

public class ExclusionaryDisjunction : MonoBehaviour, IMenuOneDimensionalActions
{
    public string[] Options = new string[2];
    Image[] OptionBackgrounds;


    int index = 0;
    void Awake() {
        OptionBackgrounds = new Image[Options.Length];
        for (int i=0; i<Options.Length; i++) {
            OptionBackgrounds[i] = gameObject.GetComponentsInChildren<Image>().Single(x => x.gameObject.name == Options[i]);
        }
        var _actions = Game.Instance.RequestActionMap<MenuOneDimensionalActions>();
        if (_actions.HasValue)
            _actions.Value.SetCallbacks(this);
    }

    public void OnNewaction(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

}
