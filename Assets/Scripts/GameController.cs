﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class GameController : MonoBehaviour
{
    public bool gameIsPaused = false;
    public bool ketIsNew = false;
    private SpawnManager _spawnManager;

    public GameObject pauseMenu;

    public GameObject gameMenu;

    public GameObject endGameMenu;

    public GameObject txt2;

    public static PlayGamesPlatform platform;

    public Text txt;
    public Text txt1;

    private void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1) _spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            PlayGamesPlatform.Activate();
            PlayGamesPlatform.Instance.Authenticate(SignInInteractivity.CanPromptOnce, (result) => { });
            //Social.Active.localUser.Authenticate(success => { });
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenMap()
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OpenSettings()
    {
        txt2.SetActive(false);   
    }

    public void Pause()
    {
        gameIsPaused = true;
        pauseMenu.SetActive(true);
        gameMenu.SetActive(false);
    }

    public void UnPause()
    {
        gameIsPaused = false;
        _spawnManager.ResumeSpawn();
        pauseMenu.SetActive(false);
        gameMenu.SetActive(true);
    }

    public void EndGame(int score, int bestScore)
    {
        txt.text = "Your score: " + score;
        txt1.text = "Your best score: " + bestScore;
        gameMenu.SetActive(false);
        endGameMenu.SetActive(true);
    }

    public void ChangeKer()
    {
        ketIsNew = !ketIsNew;
    }

    public void ShowLeaderBoard()
    {
        Social.ShowLeaderboardUI();
    }

    public void ExitFromGPS()
    {
        PlayGamesPlatform.Instance.SignOut();
    }
}
