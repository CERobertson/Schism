using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuQuickstart : ExclusionaryDisjunction {
    public SceneAsset[] Scenes;
    public override void Confirm(int index) {
        Game.Instance.Load(Scenes[index].name);
    }
}
