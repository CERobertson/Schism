using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static InputActions;

public class VehicleExternalConsole : ImplementsActionMap<VehicleExternalConsoleActions>, IVehicleExternalConsoleActions {
    protected override void AwakeCallback() {
        OnEnableCallback += (s, e) => Debug.Log("EXTERNAL CONSOLE: ON");
        OnDisableCallback += (s, e) => Debug.Log("EXTERNAL CONSOLE: OFF");
        enabled = false;
    }

    public void OnConsole1(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnConsole2(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnConsole3(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnConsole4(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }
}
