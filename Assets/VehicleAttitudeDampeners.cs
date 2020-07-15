using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static InputActions;

public class VehicleAttitudeDampeners : ImplementsActionMap<VehicleAttitudeDampenersActions>, IVehicleAttitudeDampenersActions {
    protected override void AwakeCallback() => enabled = false;
    public void OnCenter(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }
}
