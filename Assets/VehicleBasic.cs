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
    public VehicleDampeners Dampeners;
    public VehicleAttitudes Attitudes;
    public VehicleMotors Motors;
    public Camera Camera;
    public Quaternion Center;

    protected override void AwakeCallback() {
        if (Camera == null) {
            var vehicleCamera = new GameObject("Vehicle Camera", new Type[] { typeof(Camera) });
            vehicleCamera.transform.parent = gameObject.transform.parent;
            Camera = vehicleCamera.AddComponent<Camera>();
        }
        if (FreeLook == null) {
            FreeLook = gameObject.AddComponent<VehicleFreeLook>();
            FreeLook.Camera = Camera;
            FreeLook.CenterOfVehicle = this;
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
            Attitudes.CenterOfVehicle = Camera.gameObject;
            Attitudes.OnEnableCallback += (s, e) => { if (!e.HasValue) Debug.LogWarning("Failed to enable Attitudes"); };
        }
        if (Motors == null) {
            Motors = gameObject.AddComponent<VehicleMotors>();
            Attitudes.CenterOfVehicle = Camera.gameObject;
            Motors.OnEnableCallback += (s, e) => { if (!e.HasValue) Debug.LogWarning("Failed to enable Motors"); };
        }
        Center = gameObject.transform.rotation;
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
            StartCoroutine(CenterCamera());
        }
    }
    IEnumerator CenterCamera() {
        var progress = 0.0f;
        while (progress < 1) {
            Camera.transform.rotation = Quaternion.Slerp(Camera.transform.rotation, Center, progress);
            yield return new WaitForFixedUpdate();
            progress += Time.deltaTime;
        }
    }

    public void OnToggleLookMode(InputAction.CallbackContext context) {
        context.FastPress(() => { ToggleLookMode(); });
    }

    public void OnToggleConsole(InputAction.CallbackContext context) {
        context.FastPress(_ => ExternalConsole.enabled = true, _ => InternalConsole.enabled = true);
        context.SlowRelease(() => { ExternalConsole.enabled = false; InternalConsole.enabled = false; });
    }
}
