using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class circle_manager : MonoBehaviour
{
    public GameObject game_start_ui;
    public GameObject game_playing_ui;
    public GameObject game_end_ui;
    public GameObject game_ring;
    public GameObject no_money;
    public AudioClip windowSound;
    public AudioClip startSound;
    AudioSource audioSource;

    Vector3 initialPosition;
    public Transform objectToMove;

    public Animator animator; 
    public Animator nomoney;

    int money;

    public enum GameState
    {
        Start,
        Playing,
    }

    public GameState state;

    void Awake()
    {
        state = GameState.Start;
        audioSource = this.GetComponent<AudioSource>();
    }

    void Start()
    {
        GameStart();
        money = PlayerPrefs.GetInt("Wallet_Money");
    }

    void GameStart()
    {
        state = GameState.Start;
        game_start_ui.SetActive(true);
        game_ring.SetActive(false);

    }

    public void GamePlay()
    {
        if(money >= 50)
        {
            state = GameState.Playing;
            money = money - 50;
            PlayerPrefs.SetInt("Wallet_Money", money);
            game_start_ui.SetActive(false);
            game_playing_ui.SetActive(true);
            game_ring.SetActive(true);
            audioSource.PlayOneShot(startSound);
            animator.SetTrigger("go");
        }
        else
        {
            nomoney.SetTrigger("nomoney");
            audioSource.PlayOneShot(windowSound);
        }
        
    }

    public void GameEnd()
    {
        game_playing_ui.SetActive(false);
        game_end_ui.SetActive(true);
        
        game_ring.SetActive(false);
        
    }

    public void Restart()
    {
        if(money >= 50)
        {
            game_playing_ui.SetActive(true);
            game_end_ui.SetActive(false);
            ring_left.i = 5;
            money = money - 50;
            PlayerPrefs.SetInt("Wallet_Money", money);
            game_ring.SetActive(true);
            objectToMove.position = initialPosition;
            audioSource.PlayOneShot(startSound);
            animator.SetTrigger("go");
            new_accelerometer.isButtonPressed = true;
            GameObject.Find("sensor").GetComponent<new_accelerometer>().restartCorutine();
        }
        else
        {
            nomoney.SetTrigger("nomoney");
            audioSource.PlayOneShot(windowSound);
        }
        
    }
}
