using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float trust = 1.0f;
    public float hp = 100;
    public bool gameIsOver = false;
    public TouchPadScript touchPad;
    public int score;
    public Text txt;
    private GameController _gameController;

    private void Start()
    {
        _gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    private void FixedUpdate()
    {
        if(!gameIsOver && !_gameController.gameIsPaused)
        {
            if (hp <= 0)
            {
                gameIsOver = true;
                Destroy(gameObject);
            }
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector2 direction = touchPad.GetDirection();
            GetComponent<Rigidbody2D>().velocity = new Vector3(direction.x, direction.y, 0f) * trust;
            score++;
            txt.text = "Score: " + score;
        }
        if(gameIsOver) _gameController.EndGame(score);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Asteroids"))
        {
            hp -= other.gameObject.GetComponent<MoveDown>().damage;
            Destroy(other.gameObject);
        }
    }
    
}
