using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public LoadingScreen LoadingScreen;
    public int SceneBuildIndex;
    public GameObject POV;
    void Awake() {
        SceneBuildIndex = gameObject.scene.buildIndex;
        Game.Instance.CurrentScene = this;
        POV?.SetActive(true);
    }
}
