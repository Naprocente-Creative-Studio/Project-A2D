using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float trust = 2.0f;
    public float hp = 100;
    public bool gameIsOver = false;
    public int score;
    public Text txt;
    private Vector3 smoothPos;
    private GameController _gameController;
    private Vector2 startPos;
    public GameObject Buttons;
    private bool goLeft = false;
    private bool goRight = false;
    private float sideBorder = 2.5f;

    private void Start()
    {
        _gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    private void FixedUpdate()
    {
        if (_gameController.ketIsNew)
        {
            trust = 3.0f;
            Buttons.SetActive(true);
        }
        if(!gameIsOver && !_gameController.gameIsPaused)
        {
            if (hp <= 0)
            {
                gameIsOver = true;
                Destroy(gameObject);
            }

            if (!_gameController.ketIsNew)
            {
                Buttons.SetActive(false);
                if (Input.touchCount > 0)
                {
                    Touch touch = Input.GetTouch(0);
                    if (touch.phase == TouchPhase.Moved)
                    {
                        transform.position = new Vector3(
                            transform.position.x + touch.deltaPosition.x * trust,
                            transform.position.y + touch.deltaPosition.y * trust,
                            transform.position.z);
                    }
                }
            }
            else
            {
                if (goLeft && transform.position.x < sideBorder) transform.Translate(Vector3.right * trust * Time.deltaTime);
                if (goRight && transform.position.x > -sideBorder) transform.Translate(Vector3.left * trust * Time.deltaTime);
                
            }
            score++;
            txt.text = "" + score;
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

    public void GoLeft()
    {
        goLeft = !goLeft;
    }

    public void GoRight()
    {
        goRight = !goRight;
    }
    
}
