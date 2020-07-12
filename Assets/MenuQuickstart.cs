using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuQuickstart : ExclusionaryDisjunction {
    public SceneAsset[] Scenes;
    public GameObject ControlAttract;
    public GameObject Canvas;

    public override void Cancel() {
        ControlAttract.SetActive(true);
        Canvas.SetActive(false);
    }

    public override void Confirm(int index) => Game.Instance.Load(Scenes[index].name);
}
