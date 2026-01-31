using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potato_manager : MonoBehaviour
{
    public GameObject game_start_ui;
    public GameObject game_playing_ui;
    public AudioClip successSound;
    AudioSource audioSource;

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
    }

    void GameStart()
    {
        state = GameState.Start;
        game_start_ui.SetActive(true);

    }

    public void GamePlay()
    {
        audioSource.PlayOneShot(successSound);
        state = GameState.Playing;
        game_start_ui.SetActive(false);
        game_playing_ui.SetActive(true);

    }
}
