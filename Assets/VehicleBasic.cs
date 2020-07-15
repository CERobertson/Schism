using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static InputActions;

public class VehicleBasic : ImplementsActionMap<VehicleBasicActions>, IVehicleBasicActions {
    public VehicleFreeLook FreeLook;
    public VehicleExternalConsole ExternalConsole;
    public VehicleInternalConsole InternalConsole;
    public VehicleAttitudeDampeners AttitudeDampeners;
    public VehicleDampeners Dampeners;
    public VehicleAttitudes Attitudes;
    public VehicleMotors Motors;

    protected override void AwakeCallback() {
        if (FreeLook == null) {
            FreeLook = gameObject.AddComponent<VehicleFreeLook>();
            FreeLook.OnEnableCallback += (s, e) => { if (!e.HasValue) Debug.LogWarning("Failed to enable Free Look"); };
        }
        if (ExternalConsole == null) {
            ExternalConsole = gameObject.AddComponent<VehicleExternalConsole>();
            ExternalConsole.OnEnableCallback += (s, e) => { if (!e.HasValue) Debug.LogWarning("Failed to enable External Console"); };
        }
        if (InternalConsole == null) {
            InternalConsole = gameObject.AddComponent<VehicleInternalConsole>();
            InternalConsole.OnEnableCallback += (s, e) => { if (!e.HasValue) Debug.LogWarning("Failed to enable Internal Console"); };
        }
        if (AttitudeDampeners == null) {
            AttitudeDampeners = gameObject.AddComponent<VehicleAttitudeDampeners>();
            AttitudeDampeners.OnEnableCallback += (s, e) => { if (!e.HasValue) Debug.LogWarning("Failed to enable Attitude Dampeners"); };
        }
        if (Dampeners == null) {
            Dampeners = gameObject.AddComponent<VehicleDampeners>();
            Dampeners.OnEnableCallback += (s, e) => { if (!e.HasValue) Debug.LogWarning("Failed to enable Dampeners"); };
        }
        if (Attitudes == null) {
            Attitudes = gameObject.AddComponent<VehicleAttitudes>();
            Attitudes.OnEnableCallback += (s, e) => { if (!e.HasValue) Debug.LogWarning("Failed to enable Attitudes"); };
        }
        if (Motors == null) {
            Motors = gameObject.AddComponent<VehicleMotors>();
            Motors.OnEnableCallback += (s, e) => { if (!e.HasValue) Debug.LogWarning("Failed to enable Motors"); };
        }
    }

    IVehicleFreeLookActions FreeLookActions;
    IVehicleExternalConsoleActions ExternalConsoleActions;
    IVehicleInternalConsoleActions InternalConsoleActions;
    IVehicleAttitudeDampenersActions AttitudeDampenersActions;
    IVehicleDampenersActions DampenersActions;
    IVehicleAttitudesActions AttitudesActions;
    IVehicleMotorsActions MotorActions;


    public void OnToggleLookMode(InputAction.CallbackContext context) {
        throw new NotImplementedException();
    }

    public void OnToggleConsole(InputAction.CallbackContext context) {
        context.FastPress(() => ExternalConsole.enabled = true, () => InternalConsole.enabled = true);
        context.SlowRelease(() => { ExternalConsole.enabled = false; InternalConsole.enabled = false; });
    }
}
