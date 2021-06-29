using GoogleMobileAds.Api;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour
{
    public int hp = 3;
    public bool gameOverTrigger = false, pauseTrigger = false;
    public int score, money;
    public GameObject touchObject;
    private GameObject shield;
    public Material engMaterial;
    public GameObject[] explPrefabs;
    public Text moneyTxt, scoreTxt, bestScoreTxt, endScoreTxt, endMoneyTxt;
    public InterstitialAd interstitialAd;
    public GameObject spawnManager;
    public GameObject[] shipsPrefabs;
    public GameObject pauseMenu, gameMenu, endGameMenu, starfieldParticle;
    private GameObject player;

    void Start()
    {
        player = Instantiate(shipsPrefabs[2], DataBase.spawnPos, transform.rotation);
        shield = player.transform.GetChild(0).gameObject;
    }


    void FixedUpdate()
    {
        GamePlayCycle();
    }

    void GamePlayCycle()
    {
        if (pauseTrigger && touchObject.activeInHierarchy) touchObject.SetActive(false);
        if (!gameOverTrigger && !pauseTrigger)
        {
            if (hp < 0)
            {
                gameOverTrigger = true;
                Destroy(player);
            }

            if (!touchObject.activeInHierarchy) touchObject.SetActive(true);

            if (hp == 3) shield.GetComponent<SpriteRenderer>().color = DataBase.shieldColors[0];

            if (hp == 2) shield.GetComponent<SpriteRenderer>().color = DataBase.shieldColors[1];

            if (hp == 1)
            {
                if (!shield.GetComponent<SpriteRenderer>().enabled) shield.GetComponent<SpriteRenderer>().enabled = true;
                shield.GetComponent<SpriteRenderer>().color = DataBase.shieldColors[2];
            }

            if (hp == 0)
            {
                shield.GetComponent<SpriteRenderer>().enabled = false;
            }
            score++;
            scoreTxt.text = "" + score;
            moneyTxt.text = "" + money;
        }
        if (gameOverTrigger) GameOverCycle();
    }

    void GameOverCycle()
    {
        GameEndAd();
        money += PlayerPrefs.GetInt("Money", 0);
        PlayerPrefs.SetInt("Money", money);
        EndGame(score, PlayerPrefs.GetInt("BestScore"), PlayerPrefs.GetInt("Money"));
        if (score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", score);
            Social.ReportScore(score, DataBase.leaderboardID, (bool success) => { });
        }
    }

    void GameEndAd()
    {
        interstitialAd = new InterstitialAd(DataBase.adScreenID);
        AdRequest request = new AdRequest.Builder().Build();
        interstitialAd.LoadAd(request);
        interstitialAd.OnAdLoaded += OnAddLoaded;
    }

    public void CometTrailContact(Collision2D other)
    {
        money++;
        if (hp < 3)
        {
            hp++;
            shield.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
        }
        Instantiate(explPrefabs[1], other.transform.position, other.transform.rotation);
        Destroy(other.gameObject);
    }

    public void AsteroidCollision(Collider2D other)
    {
        Instantiate(explPrefabs[0], other.transform.position, other.transform.rotation);
        hp--;
        if (hp >= 0) shield.transform.GetChild(1).GetComponent<ParticleSystem>().Play();
        if (hp < 0) Instantiate(explPrefabs[0], player.transform.position, player.transform.rotation);
        Destroy(other.gameObject);
    }

    public void CometCollission(Collider2D other)
    {
        hp--;
        if (hp >= 0) shield.transform.GetChild(1).GetComponent<ParticleSystem>().Play();
        if (hp < 0) Instantiate(explPrefabs[0], player.transform.position, player.transform.rotation);
        Instantiate(explPrefabs[0], other.transform.position, other.transform.rotation);
        Destroy(other.gameObject);
    }

    public void SharpCollision(Collider2D other)
    {
        Instantiate(explPrefabs[0], other.transform.position, other.transform.rotation);
        hp--;
        if (hp >= 0) shield.transform.GetChild(1).GetComponent<ParticleSystem>().Play();
        if (hp < 0) Instantiate(explPrefabs[0], player.transform.position, player.transform.rotation);
        Destroy(other.gameObject);
    }

    void OnAddLoaded(object sender, System.EventArgs args)
    {
        interstitialAd.Show();
    }

    public void Pause()
    {
        pauseTrigger = true;
        starfieldParticle.GetComponent<ParticleSystem>().Pause();
        pauseMenu.SetActive(true);
        gameMenu.SetActive(false);
    }

    public void UnPause()
    {
        pauseTrigger = false;
        starfieldParticle.GetComponent<ParticleSystem>().Play();
        spawnManager.GetComponent<SpawnManager>().ResumeSpawn();
        pauseMenu.SetActive(false);
        gameMenu.SetActive(true);
    }

    public void EndGame(int score, int bestScore, int money)
    {
        endScoreTxt.text = "Your score: " + score;
        bestScoreTxt.text = "Your best score: " + bestScore;
        endMoneyTxt.text = "" + money;
        starfieldParticle.GetComponent<ParticleSystem>().Pause();
        gameMenu.SetActive(false);
        endGameMenu.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
