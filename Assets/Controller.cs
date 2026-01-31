using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public SceneTransition sceneTransition; //取得SceneTransition中的函式
    public string targetSceneName;

    private void OnMouseDown() 
    {
        sceneTransition.LoadScene(targetSceneName);
    }
}
