using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float trust = 1.0f;
    public float hp = 100;
    public bool gameIsOver = false;
    public int score;
    public Text txt;
    private GameController _gameController;
    private Vector2 startPos;

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
            if (Input.touchCount > 0) {
                var touch = Input.GetTouch(0);

                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        startPos = touch.position;
                        break;

                    case TouchPhase.Moved:
                        Vector2 dir = touch.position - startPos;
                        Vector3 pos = transform.position + new Vector3(dir.x, dir.y, transform.position.z);
                        pos.Normalize();
                        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime * trust);
                        break;
                }
            }
            score++;
            txt.text = "Score: " + score;
        }
        if(gameIsOver) _gameController.EndGame(score);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Asteroids") || other.gameObject.CompareTag("SharpAst"))
        {
            hp -= other.gameObject.GetComponent<MoveDown>().damage;
            Destroy(other.gameObject);
        }
    }
    
}
