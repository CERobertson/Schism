using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static InputActions;

public class VehicleFreeLook : ImplementsActionMap<VehicleFreeLookActions>, IVehicleFreeLookActions {
    public Camera Camera;
    public VehicleBasic CenterOfVehicle;
    public bool InvertX = false;
    public bool InvertY = false;
    public float SensitivityX = 1.0f;
    public float SensitivityY = 1.0f;

    protected override void AwakeCallback() => enabled = false;
    public void OnAlignWithView(InputAction.CallbackContext context) => context.FastPress(() => StartCoroutine(AlignWithView()));
    IEnumerator AlignWithView() {
        var progress = 0.0f;
        CenterOfVehicle.Center = Camera.transform.rotation;
        while (progress < 1) {
            CenterOfVehicle.transform.rotation = Quaternion.Slerp(CenterOfVehicle.transform.rotation, CenterOfVehicle.Center, progress);
            yield return new WaitForFixedUpdate();
            progress += Time.deltaTime;
        }
    }
    float maximum = 180.0f;
    float minumum = -180.0f;
    public void OnLookX(InputAction.CallbackContext context) => context.FastPress(v => Rotate(v * SensitivityX, Vector3.right));
    void Rotate(float value, Vector3 axis) {
        //transform.rotation = transform.e
    }

    public void OnLookY(InputAction.CallbackContext context) {
        OnDisableCallback += (s, e) => Debug.Log("OnLookY");
    }

    public void OnRoll(InputAction.CallbackContext context) {
        OnDisableCallback += (s, e) => Debug.Log("OnRoll");
    }
}
