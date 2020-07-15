using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static InputActions;

public class VehicleAttitudes : ImplementsActionMap<VehicleAttitudesActions>, IVehicleAttitudesActions {
    public void OnPitch(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnRollLeft(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnRollRight(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnYaw(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    protected override void AwakeCallback() => enabled = false;
}
