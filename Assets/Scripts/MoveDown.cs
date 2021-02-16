using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 6.0f;
    public float damage = 25;
    private float downBorder = -6;
    private PlayerController playerScript;
    private GameController _gameController;

    private void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        _gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    private void FixedUpdate()
    {
        if (!playerScript.gameIsOver && !_gameController.gameIsPaused)
        {
            gameObject.transform.Translate(Vector3.down * (Time.deltaTime * speed));
            if (gameObject.transform.position.y < downBorder) Destroy(gameObject);
        }
    }
}
