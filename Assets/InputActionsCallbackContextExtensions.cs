using System;
using UnityEngine.InputSystem;
using static InputActions;
public static class InputActionsCallbackContextExtensions
{
    public static void FastPress(this InputAction.CallbackContext context, Action action) {
        if (context.phase == InputActionPhase.Started)
            action();
    }
    public static void SlowRelease(this InputAction.CallbackContext context, Action action) {
        if (context.phase == InputActionPhase.Canceled)
            action();
    }
    public static void FastPress(this InputAction.CallbackContext context, Action positiveAction, Action negativeAction) {
        if (context.phase == InputActionPhase.Started) {
            var value = context.ReadValue<float>();
            if (value != 0) {
                if (value > 0)
                    positiveAction();
                else
                    negativeAction();
            }
        }
    }
}
