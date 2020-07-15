﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static InputActions;

public class VehicleBasic : ImplementsActionMap<VehicleBasicActions>, IVehicleBasicActions {
    public VehicleFreeLook FreeLook;
    public VehicleExternalConsole ExternalConsole;
    public VehicleInternalConsole InternalConsole;
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
    IVehicleDampenersActions DampenersActions;
    IVehicleAttitudesActions AttitudesActions;
    IVehicleMotorsActions MotorActions;

    public ActionMap ActionLock;
    void SetAction(Action set, ActionMap action) {
        if (!ActionLock.Contains(action))
            set();
    }
    bool lookModeState;
    void ToggleLookMode() {
        lookModeState ^= true;
        if (lookModeState) {
            SetAction(() => Attitudes.enabled = false, ActionMap.VehicleAttitudes);
            SetAction(() => FreeLook.enabled = true, ActionMap.VehicleFreeLook);
        }
        else {
            SetAction(() => FreeLook.enabled = false, ActionMap.VehicleFreeLook);
            SetAction(() => Attitudes.enabled = true, ActionMap.VehicleAttitudes);
        }
    }

    public void OnToggleLookMode(InputAction.CallbackContext context) {
            context.FastPress(() => { ToggleLookMode(); });
    }

    public void OnToggleConsole(InputAction.CallbackContext context) {
        context.FastPress(() => ExternalConsole.enabled = true, () => InternalConsole.enabled = true);
        context.SlowRelease(() => { ExternalConsole.enabled = false; InternalConsole.enabled = false; });
    }
}