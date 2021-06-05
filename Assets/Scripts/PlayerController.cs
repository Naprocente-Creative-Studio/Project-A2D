using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class PlayerController : MonoBehaviour
{
    public float trust = 2.0f;
    public float hp = 3;
    public bool gameIsOver = false;
    public int score;
    public Text txt;
    private GameController _gameController;
    public GameObject Buttons;
    private bool goLeft = false;
    private bool goRight = false;
    private float sideBorder = 2.5f;
    public GameObject touch;
    public GameObject shield;
    public Color color3, color2, color1;
    [HideInInspector] private const string leaderBoard = "CgkI64T-2s8EEAIQAQ";

    private void Start()
    {
        _gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    private void FixedUpdate()
    {
        if (_gameController.ketIsNew && SceneManager.GetActiveScene().buildIndex == 1)
        {
            trust = 3.0f;
            Buttons.SetActive(true);
            touch.SetActive(false);
        }

        if (SceneManager.GetActiveScene().buildIndex == 1 && !_gameController.ketIsNew && _gameController.gameIsPaused && touch.activeInHierarchy) touch.SetActive(false);
        if(!gameIsOver && !_gameController.gameIsPaused && SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (hp < 0)
            {
                gameIsOver = true;
                Destroy(gameObject);
            }

            if (hp < 4)
            {
                StartCoroutine(HealthAdd());
            }

            if (!touch.activeInHierarchy) touch.SetActive(true);

            if (hp == 3) shield.GetComponent<SpriteRenderer>().color = color3;

            if(hp == 2) shield.GetComponent<SpriteRenderer>().color = color2;

            if(hp == 1) shield.GetComponent<SpriteRenderer>().color = color1;

            if (hp == 0) shield.SetActive(false);

            if (!_gameController.ketIsNew)
            {
                Buttons.SetActive(false);
                touch.SetActive(true);
            }
            else
            {
                if (goLeft && transform.position.x < sideBorder) transform.Translate(Vector3.right * trust * Time.deltaTime);
                if (goRight && transform.position.x > -sideBorder) transform.Translate(Vector3.left * trust * Time.deltaTime);
                
            }
            score++;
            txt.text = "" + score;
        }
        if (gameIsOver)
        {
            PlayerData data = SaveSystem.LoadPlayer();
            _gameController.EndGame(score, data.score);
            if (score > data.score)
            {
                SaveSystem.SavePlayer(this);
                Social.ReportScore(score, leaderBoard, (bool success) => { });
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Asteroids"))
        {
            hp--;
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

    IEnumerator HealthAdd()
    {
        yield return new WaitForSeconds(5);
        hp++;
        StopCoroutine("HealthAdd");
    }
    
}
