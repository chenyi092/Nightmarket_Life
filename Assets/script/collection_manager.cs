using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class collection_manager : MonoBehaviour
{
    public GameObject tea;
    public GameObject drink;
    public GameObject rabbit;
    public GameObject wine;

    public GameObject tea_button;
    public GameObject drink_button;
    public GameObject rabbit_button;
    public GameObject wine_button;

    public bool tea_flag = false;
    public bool drink_flag = false;
    public bool rabbit_flag = false;
    public bool wine_flag = false;

    public AudioClip successSound;
    AudioSource audioSource;

    public int drink_collect;
    public int rabbit_collect;
    public int wine_collect;

    public GameObject drink_image;
    public GameObject rabbit_image;
    public GameObject wine_image;


    void Awake()
    {
       audioSource = this.GetComponent<AudioSource>();
       drink_collect = PlayerPrefs.GetInt("drink_collect");
       rabbit_collect = PlayerPrefs.GetInt("rabbit_collect");
       wine_collect = PlayerPrefs.GetInt("wine_collect");
       //PlayerPrefs.SetInt("wine_collect", 0);
    }

    void Start()
    {
        if(drink_collect == 0)
        {
            drink_image.SetActive(false);
            drink_button.SetActive(false);
        }

        if(rabbit_collect == 0)
        {
            rabbit_image.SetActive(false);
            rabbit_button.SetActive(false);
        }

        if(wine_collect == 0)
        {
            wine_image.SetActive(false);
            wine_button.SetActive(false);
        }
    }
    
    public void Press_tea()
    {
        Debug.Log("tea pressed");
        audioSource.PlayOneShot(successSound);
        tea.SetActive(true);
        tea_button.SetActive(false);
        tea_flag = true;

    }

    public void Press_drink()
    {
        Debug.Log("drink pressed");
        audioSource.PlayOneShot(successSound);
        drink.SetActive(true);
        drink_button.SetActive(false);
        drink_flag = true;
    }

    public void Press_rabbit()
    {
        Debug.Log("rabbit pressed");
        audioSource.PlayOneShot(successSound);
        rabbit.SetActive(true);
        rabbit_button.SetActive(false);
        rabbit_flag = true;
    }

    public void Press_wine()
    {
        Debug.Log("wine pressed");
        audioSource.PlayOneShot(successSound);
        wine.SetActive(true);
        wine_button.SetActive(false);
        wine_flag = true;
    }

    void Update()
    {
        if(tea_flag == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                tea.SetActive(false);
                tea_button.SetActive(true);
                tea_flag = false;
                Debug.Log("tea disappear");
            }
        }
        else if(drink_flag == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                drink.SetActive(false);
                drink_button.SetActive(true);
                drink_flag = false;
                Debug.Log("drink disappear");
            }
        }
        else if(rabbit_flag == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rabbit.SetActive(false);
                rabbit_button.SetActive(true);
                rabbit_flag = false;
                Debug.Log("rabbit disappear");
            }
        }
        else if(wine_flag == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                wine.SetActive(false);
                wine_button.SetActive(true);
                wine_flag = false;
                Debug.Log("wine disappear");
            }
        }
        else
        {

        }
    }
}
