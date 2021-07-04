using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public GameObject[] shipsPrefabs;
    public GameObject[] levelPrefabs;
    public Text hiTxt, bestScoreTxt, rankTxt, moneyShopTxt, moneyTxt;
    public GameObject player;
    public GameObject levelLoader;
    public GameObject mainMenu, shopMenu, authorMenu;
    public GameObject swipeDetector, starPartclObject;
    public int moneyTest;

    void Start()
    {
        player = Instantiate(shipsPrefabs[PlayerPrefs.GetInt("ShipIndex", 0)], DataBase.spawnPos, transform.rotation);
        Instantiate(levelPrefabs[Random.Range(0, levelPrefabs.Length)], DataBase.levelMPos, transform.rotation);
        //PlayerPrefs.SetInt("Money", moneyTest);
        ShowMoney(moneyTxt);
        ÀuthenticationGoogle();

    }

    void ÀuthenticationGoogle()
    {
        PlayGamesPlatform.Activate();
        PlayGamesPlatform.Instance.Authenticate(SignInInteractivity.CanPromptOnce, (result) => { });
        hiTxt.text = "Hi, " + Social.localUser.userName.ToString();
        PlayGamesPlatform.Instance.LoadScores(
             DataBase.leaderboardID,
             LeaderboardStart.PlayerCentered,
             1,
             LeaderboardCollection.Public,
             LeaderboardTimeSpan.AllTime,
         (LeaderboardScoreData data) => {
             bestScoreTxt.text = "Best score: " + data.PlayerScore.formattedValue;
             rankTxt.text = "Rank: " + data.PlayerScore.rank;
         });
    }

    public void StartGame()
    {
        levelLoader.GetComponent<LevelLoader>().LoadLevel(1);
    }

    public void ShowMoney(Text money)
    {
        money.text = "" + PlayerPrefs.GetInt("Money");
        Debug.Log(PlayerPrefs.GetInt("Money"));
    }

    public void ShowLeaderBoard()
    {
        Social.ShowLeaderboardUI();
    }

    public void OpenShop()
    {
        mainMenu.SetActive(false);
        swipeDetector.SetActive(false);
        player.GetComponent<Animation>().Stop();
        player.transform.GetChild(0).gameObject.SetActive(false);
        starPartclObject.GetComponent<ParticleSystem>().Pause();
        ShowMoney(moneyShopTxt);
        shopMenu.GetComponent<ShopController>().ShowShopItems();
        shopMenu.SetActive(true);
    }

    public void OpenAuthors()
    {
        mainMenu.SetActive(false);
        swipeDetector.SetActive(false);
        player.GetComponent<Animation>().Stop();
        player.transform.GetChild(0).gameObject.SetActive(false);
        starPartclObject.GetComponent<ParticleSystem>().Pause();
        authorMenu.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
