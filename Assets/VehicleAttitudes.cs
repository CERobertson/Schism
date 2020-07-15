using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static InputActions;

public class VehicleAttitudes : ImplementsActionMap<VehicleAttitudesActions>, IVehicleAttitudesActions {
    protected override void AwakeCallback() => enabled = false;
    public void OnPitch(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnRoll(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnYaw(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }
}
