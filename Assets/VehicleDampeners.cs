using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static InputActions;

public class VehicleDampeners : ImplementsActionMap<VehicleDampenersActions>, IVehicleDampenersActions {
    protected override void AwakeCallback() => enabled = false;
    public void OnDampenAllMotors(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnDampenHeave(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnDampenSurge(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnDampenSway(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }
}
