using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static InputActions;

public class VehicleFreeLook : ImplementsActionMap<VehicleFreeLookActions>, IVehicleFreeLookActions {
    protected override void AwakeCallback() => enabled = false;
    public void OnCenter(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnLookX(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnLookY(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }
}
