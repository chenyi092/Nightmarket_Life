using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shop_Random : MonoBehaviour
{
   public SceneTransition sceneTransition;
   public string targetSceneName;
   public string targetSceneName2;
   int randoms;
   public AudioClip successSound;
   AudioSource audioSource;
   
      void Awake()
   {
      audioSource = this.GetComponent<AudioSource>();
   }

   private void OnMouseDown()
   {
        audioSource.PlayOneShot(successSound);
        randoms = Random.Range(0,3);
        switch(randoms)
        {
            case 0:
               sceneTransition.LoadScene(targetSceneName);
               Debug.Log(randoms);
               break;
            
            case 1:
               sceneTransition.LoadScene(targetSceneName2);
               Debug.Log(randoms);
               break;

            case 2:
               sceneTransition.LoadScene(targetSceneName);
               Debug.Log(randoms);
               break;
         
        }
        
   }
}
