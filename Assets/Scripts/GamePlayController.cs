using GoogleMobileAds.Api;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour
{
    private int hp = 1;
    public bool gameOverTrigger = false, pauseTrigger = false, endTrigger = false, resumeTrigger = false;
    public int score, money;
    public GameObject touchObject;
    private GameObject shield;
    public Material engMaterial;
    public GameObject[] explPrefabs;
    public Text moneyTxt, scoreTxt, bestScoreTxt, endScoreTxt, endMoneyTxt;
    public InterstitialAd interstitialAd;
    public RewardedAd rewardedAd;
    public GameObject spawnManager;
    public GameObject[] shipsPrefabs;
    public GameObject pauseMenu, gameMenu, endGameMenu, starfieldParticle;
    private GameObject player;
    public GameObject levelLoader;
    public GameObject[] levelPrefabs;
    public AudioScript audioSource;
    public AudioSource bgSound;
    public bool muteSound;

    void Start()
    {
        muteSound = intToBool(PlayerPrefs.GetInt("Sound"));
        if (muteSound) bgSound.Stop();
        engMaterial.color = DataBase.flameColors[Random.Range(0, DataBase.flameColors.Length)];
        player = Instantiate(shipsPrefabs[PlayerPrefs.GetInt("ShipIndex", 0)], DataBase.spawnPos, transform.rotation);
        Instantiate(levelPrefabs[Random.Range(0, levelPrefabs.Length)], DataBase.levelPos, transform.rotation);
        shield = player.transform.GetChild(0).gameObject;
        MobileAds.Initialize(initStatus => { });
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
                player.gameObject.SetActive(false);
            }

            if (!touchObject.activeInHierarchy) touchObject.SetActive(true);

            if (hp == 1)
            {
                if (!shield.GetComponent<SpriteRenderer>().enabled) shield.GetComponent<SpriteRenderer>().enabled = true;
                shield.GetComponent<SpriteRenderer>().color = DataBase.shieldColors[0];
            }

            if (hp == 0)
            {
                shield.GetComponent<SpriteRenderer>().enabled = false;
            }
            score++;
            scoreTxt.text = "" + score;
            moneyTxt.text = "" + money;
        }
        if (gameOverTrigger && !endTrigger) GameOverCycle();
    }

    void GameOverCycle()
    {
        endTrigger = true;
        GameEndAd();
        int tmpmoney = PlayerPrefs.GetInt("Money", 0);
        money += tmpmoney;
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
        interstitialAd = new InterstitialAd("ca-app-pub-2619136704947934/2527301585");
        AdRequest request = new AdRequest.Builder().Build();
        interstitialAd.LoadAd(request);
        interstitialAd.OnAdLoaded += OnAddLoaded;
    }

    public void CometTrailContact(Collision2D other)
    {
        money++;
        if (!muteSound) audioSource.PlayShieldUp();
        if (hp < 1)
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
        if(hp == 0 && !muteSound) audioSource.PlayExpl();
        if(hp > 0 && !muteSound) audioSource.PlayShield();
        hp--;
        if (hp >= 0) shield.transform.GetChild(1).GetComponent<ParticleSystem>().Play();
        if (hp < 0) Instantiate(explPrefabs[0], player.transform.position, player.transform.rotation);
        Destroy(other.gameObject);
    }

    public void CometCollission(Collider2D other)
    {
        if (hp == 0 && !muteSound) audioSource.PlayExpl();
        if (hp > 0 && !muteSound) audioSource.PlayShield();
        hp--;
        if (hp >= 0) shield.transform.GetChild(1).GetComponent<ParticleSystem>().Play();
        if (hp < 0) Instantiate(explPrefabs[0], player.transform.position, player.transform.rotation);
        Instantiate(explPrefabs[0], other.transform.position, other.transform.rotation);
        Destroy(other.gameObject);
    }

    public void SharpCollision(Collider2D other)
    {
        Instantiate(explPrefabs[0], other.transform.position, other.transform.rotation);
        if (hp == 0 && !muteSound) audioSource.PlayExpl();
        if (hp > 0 && !muteSound) audioSource.PlayShield();
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
        if (!muteSound) audioSource.PlayMenu();
        pauseTrigger = true;
        starfieldParticle.GetComponent<ParticleSystem>().Pause();
        pauseMenu.SetActive(true);
        gameMenu.SetActive(false);
    }

    public void UnPause()
    {
        if (!muteSound) audioSource.PlayMenu();
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
        if (!muteSound) audioSource.PlayMenu();
        levelLoader.GetComponent<LevelLoader>().LoadLevel(2);
    }

    public void MainMenu()
    {
        if (!muteSound) audioSource.PlayMenu();
        levelLoader.GetComponent<LevelLoader>().LoadLevel(1);
    }

    public void MuteSound()
    {
        muteSound = !muteSound;
        if (muteSound) bgSound.Stop();
        if(!muteSound) bgSound.Play();
        PlayerPrefs.SetInt("Sound", boolToInt(muteSound));
    }

    bool intToBool(int var)
    {
        if (var == 1) return true;
        else return false;
    }

    int boolToInt(bool var)
    {
        if (var) return 1;
        else return 0;
    }
}
