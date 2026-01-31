
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Controller : MonoBehaviour
{
   public SceneTransition sceneTransition;
   public string targetSceneName;
    public AudioClip successSound;
    AudioSource audioSource;

    void Awake()
    {
       audioSource = this.GetComponent<AudioSource>();
    }

   private void OnMouseDown()
   {
        audioSource.PlayOneShot(successSound);
        sceneTransition.LoadScene(targetSceneName);
   }
}
