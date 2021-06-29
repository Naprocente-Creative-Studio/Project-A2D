using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redirect : MonoBehaviour
{
    private MainMenuController controller;
    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<MainMenuController>();
    }

    public void StartGameR()
    {
        controller.StartGame();
    }
}
