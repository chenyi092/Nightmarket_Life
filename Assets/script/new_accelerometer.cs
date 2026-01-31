using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class new_accelerometer : MonoBehaviour
{
    Vector3 value;
    public Animator animator;
    public Button triggerButton;
    public Button restart;
    public AudioClip successshootSound;
    public AudioClip failshootSound;   
    public AudioClip window;
    AudioSource audioSource;
    public static bool isButtonPressed = false;
    private bool isPlayingAnimation = false;
    public Animator wine_get;
    public Animator rabbit_get;
    public Animator drink_get;

    void Start()
    {
        triggerButton.onClick.AddListener(OnButtonPressed);
        StartCoroutine(acceleration());
        audioSource = this.GetComponent<AudioSource>();
        
    }

    IEnumerator acceleration()
    {
        Debug.Log("Coroutine started");
        while (!isButtonPressed)
        {
            //Debug.Log("Waiting for button press...");
            yield return null;
        }
        
        Debug.Log("enter animation");

        yield return new WaitForSeconds(4); //wait for intro animation
        //Debug.Log("Waited for 4 seconds");

        while(ring_left.i >= 1)
        {
            value = Input.acceleration;
            // Debug.Log("while");
            if(value.x < -0.9 && value.x > -1.3 && value.y < 1.1 && value.y > 0.7)
            {
                Debug.Log("right");
                audioSource.PlayOneShot(successshootSound);
                animator.SetTrigger("right");
                ring_left.i = ring_left.i - 1;
                isPlayingAnimation = true;
                PlayerPrefs.SetInt("drink_collect", 1);
                yield return new WaitForSeconds(3);
                isPlayingAnimation = false;
                drink_get.SetTrigger("drink_get");
                audioSource.PlayOneShot(window);
                yield return new WaitForSeconds(2);
            }
            else if(value.x < 1.6 && value.x > 1.3 && value.y < -0.15 && value.y > -0.4)
            {
                Debug.Log("middle");
                audioSource.PlayOneShot(successshootSound);
                animator.SetTrigger("middle");
                ring_left.i = ring_left.i - 1;
                isPlayingAnimation = true;
                PlayerPrefs.SetInt("rabbit_collect", 1);
                yield return new WaitForSeconds(3);
                isPlayingAnimation = false;
                rabbit_get.SetTrigger("rabbit_get");
                audioSource.PlayOneShot(window);
                yield return new WaitForSeconds(2);
            }
            else if(value.x < 1.8 && value.x > 1.4 && value.y < 0.8 && value.y > 0.4)
            {
                Debug.Log("left");
                audioSource.PlayOneShot(successshootSound);
                animator.SetTrigger("left");
                ring_left.i = ring_left.i - 1;
                isPlayingAnimation = true;
                PlayerPrefs.SetInt("wine_collect", 1);
                yield return new WaitForSeconds(3);
                isPlayingAnimation = false;
                wine_get.SetTrigger("wine_get");
                audioSource.PlayOneShot(window);
                yield return new WaitForSeconds(2);
            }
            else if(Mathf.Abs(value.x) < 1.2 && Mathf.Abs(value.x) > 0.7 || Mathf.Abs(value.x) > 2)
            {
                if(Mathf.Abs(value.y) < 0.3 && Mathf.Abs(value.y) > 0.2 || Mathf.Abs(value.y) > 0.8)
                {
                    Debug.Log("fail");
                    audioSource.PlayOneShot(failshootSound);
                    ring_left.i = ring_left.i - 1;
                    isPlayingAnimation = true;
                    animator.SetTrigger("fail");
                    yield return new WaitForSeconds(4);
                    isPlayingAnimation = false;
                }
                else
                {
                    yield return null;
                }
            }
            else
            {
                yield return null; // 沒有符合條件，等待下一幀
            }
        }

        if(ring_left.i == 0 && !isPlayingAnimation)
        {
            // Debug.Log("Game end");
            GameObject.Find("gamemanager").GetComponent<circle_manager>().GameEnd();
            
            isButtonPressed = false;
        }

    }

    void OnButtonPressed()
    {
        Debug.Log("Button pressed");
        isButtonPressed = true;
    }

    public void restartCorutine()
    {
        StopCoroutine(acceleration());
        StartCoroutine(acceleration());
    }



}
