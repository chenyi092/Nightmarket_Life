using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potatopress : MonoBehaviour
{
    public Animator animator; 
    public Animator animatorplus;
    public AudioClip successSound;
    AudioSource audioSource;


    int money;

    void Awake()
    {
       audioSource = this.GetComponent<AudioSource>();
    }
    void Start()
    {
        money = PlayerPrefs.GetInt("Wallet_Money");
    }
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(successSound);
            money = money + 5;
            PlayerPrefs.SetInt("Wallet_Money", money);
            animatorplus.SetTrigger("plus5");
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("press");
        }
         

    }
}
