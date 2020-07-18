using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static InputActions;

public class VehicleMotors : ImplementsActionMap<VehicleMotorsActions>, IVehicleMotorsActions {
    public GameObject CenterOfVehicle;
    public void OnHeaveDown(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnHeaveUp(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnSurge(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnSway(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    protected override void AwakeCallback() => enabled = false;
}
