using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading;

public class artist_yesno : MonoBehaviour
{
    public SceneTransition sceneTransition;
    public string targetSceneName;

    int minus_random;

    public Button triggerButton;

    public GameObject minusmoney;
    public GameObject moneybeybey;
    public GameObject got;
    public Animator animator_get;
    public Animator animator_disappear;
    public Animator animator_yesno;
    public GameObject yesno;
    public Animator get;
    public static bool isButtonPressed = false;
    int randoms;
    public static bool yes_until = false;
    int money_current;
    public AudioClip tab;
    public AudioClip window;
    AudioSource audioSource;

    void Start()
    {
        isButtonPressed = false;
        yes_until = false;
        animator_yesno.SetTrigger("yesno");
        triggerButton.onClick.AddListener(OnButtonPressed);
        StartCoroutine(yes_random());
        money_current = PlayerPrefs.GetInt("Wallet_Money");
        audioSource = this.GetComponent<AudioSource>();
    }
    
    
    IEnumerator yes_random()
    {
        while (!isButtonPressed)
        {
            //Debug.Log("Waiting for button press...");
            yield return null;
        }

        randoms = Random.Range(0,2);

        switch(randoms)
        {
            //lost money version
            case 0:
                minus_random = Random.Range(0,51);
                minusmoney.GetComponent<TextMeshProUGUI>().text = "" + minus_random;
                moneybeybey.SetActive(true);
                yesno.SetActive(false);
                PlayerPrefs.SetInt("Wallet_Money", money_current-minus_random);
                yes_until = true;
                break;
            
            //get rabbit version
            case 1:
                animator_get.SetTrigger("artist_get");
                animator_disappear.SetTrigger("disappear");
                yesno.SetActive(false);
                yield return new WaitForSeconds(3);
                //got.SetActive(true);
                get.SetTrigger("get");
                audioSource.PlayOneShot(window);
                //PlayerPrefs.SetInt("rabbit_collect", 1);
                yes_until = true;
                break;
        }

    }
    
    public void yes()
    {
        Debug.Log("yes");
        audioSource.PlayOneShot(tab);
    } 

    public void no()
    {
        Debug.Log("no");
        sceneTransition.LoadScene(targetSceneName);
        audioSource.PlayOneShot(tab);
    }


    void OnButtonPressed()
    {
        Debug.Log("Button pressed");
        isButtonPressed = true;
    }

}
