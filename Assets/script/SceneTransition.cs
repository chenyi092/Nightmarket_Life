using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public Animator animator;
    public float transitionTime = 1f; //動畫時長


    public void LoadScene(string name)
    {
        StartCoroutine(Transition(name, transitionTime));
    }

    IEnumerator Transition(string name, float time)
    {
        //play transition animation
        animator.SetTrigger("New Trigger"); //此處""中的名字需與創建的Animator Trigger名稱相同
        ring_left.i = 5;

        //wait transition time
        yield return new WaitForSeconds(time);

        //load scene
        SceneManager.LoadScene(name); 
    }
}

       