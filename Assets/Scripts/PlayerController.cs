using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using GoogleMobileAds.Api;

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
    public Material engineMat;
    public Color color3, color2, color1;
    private Vector4[] flameColors = { new Vector4(0.07453719f, 0.1432364f, 0.6320754f, 1.0f), new Vector4(0.8679245f, 0.6567881f, 0.06140975f, 1.0f), new Vector4(0.8666667f, 0.1587057f, 0.06274509f, 1.0f)};
    [HideInInspector] private const string leaderBoard = "CgkI64T-2s8EEAIQAQ";
    [HideInInspector] private const string adScreen = "ca-app-pub-2619136704947934/2527301585";
    public InterstitialAd interstitialAd;

    private void Start()
    {
        _gameController = GameObject.Find("GameController").GetComponent<GameController>();
        engineMat.color = flameColors[Random.Range(0, flameColors.Length)];        
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
        if (!gameIsOver && !_gameController.gameIsPaused && SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (hp < 0)
            {
                gameIsOver = true;
                Destroy(gameObject);
            }

            if (!touch.activeInHierarchy) touch.SetActive(true);

            if (hp == 3) shield.GetComponent<SpriteRenderer>().color = color3;

            if (hp == 2) shield.GetComponent<SpriteRenderer>().color = color2;

            if (hp == 1)
            {
                if (!shield.GetComponent<SpriteRenderer>().enabled) shield.GetComponent<SpriteRenderer>().enabled = true;
                shield.GetComponent<SpriteRenderer>().color = color1;
            }

            if (hp == 0) shield.GetComponent<SpriteRenderer>().enabled = false;

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
            interstitialAd = new InterstitialAd(adScreen);
            AdRequest request = new AdRequest.Builder().Build();
            interstitialAd.LoadAd(request);
            interstitialAd.OnAdLoaded += OnAddLoaded;
            PlayerData data = SaveSystem.LoadPlayer();
            _gameController.EndGame(score, data.score);
            if (score > data.score)
            {
                SaveSystem.SavePlayer(this);
                Social.ReportScore(score, leaderBoard, (bool success) => { });
            }
        }
    }

    public void OnAddLoaded(object sender, System.EventArgs args)
    {
        interstitialAd.Show();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Asteroids"))
        {
            hp--;
            shield.transform.GetChild(1).GetComponent<ParticleSystem>().Play();
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Comet"))
        {
            if (other.contacts[0].collider.gameObject.CompareTag("addHp"))
            {
                //other.contacts[0].collider.gameObject.GetComponent<ParticleSystem>().Play();
                if (hp < 3)
                {
                    hp++;
                    shield.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
                }
                Destroy(other.gameObject);
            }
            else if (other.contacts[0].collider.gameObject.CompareTag("Asteroids"))
                {
                    hp--;
                    shield.transform.GetChild(1).GetComponent<ParticleSystem>().Play();
                    Destroy(other.gameObject);
                }
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
