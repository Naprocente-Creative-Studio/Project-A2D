﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public bool gameIsPaused = false;
    private SpawnManager _spawnManager;

    public GameObject pauseMenu;

    public GameObject gameMenu;

    public GameObject endGameMenu;

    public Text txt;
    // Start is called before the first frame update

    private void Start()
    {
        _spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeLanguage()
    {
        
    }

    public void OpenMap()
    {
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OpenSettings()
    {
        
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
        _spawnManager.ResumeSpawnAsteroids();
        pauseMenu.SetActive(false);
        gameMenu.SetActive(true);
    }

    public void EndGame(int score)
    {
        txt.text = "Your score: " + score;
        gameMenu.SetActive(false);
        endGameMenu.SetActive(true);
    }
}
