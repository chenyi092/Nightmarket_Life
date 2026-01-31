using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
    public SceneTransition sceneTransition;
    public string targetSceneName;
    public GameObject moneybeybey;

    void Update()
    {
        if(artist_yesno.yes_until == true)
        {
            if(Input.GetMouseButtonDown(0))
            {
                sceneTransition.LoadScene(targetSceneName);
                moneybeybey.SetActive(false);
            }
        }

        
    }
}
