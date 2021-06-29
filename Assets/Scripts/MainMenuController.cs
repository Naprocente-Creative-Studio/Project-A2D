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
    public Text hiTxt, bestScoreTxt, rankTxt, moneyShopTxt, moneyTxt;
    public GameObject player;
    public GameObject levelLoader;
    public GameObject mainMenu, shopMenu, authorMenu;

    void Start()
    {
        player = Instantiate(shipsPrefabs[PlayerPrefs.GetInt("ShipIndex", 0)], DataBase.spawnPos, transform.rotation);
        ShowMoney(moneyTxt);
        Àuthentication();
    }

    void Àuthentication()
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

    void ShowMoney(Text money)
    {
        money.text = "" + PlayerPrefs.GetInt("Money");
    }

    public void ShowLeaderBoard()
    {
        Social.ShowLeaderboardUI();
    }

    public void OpenShop()
    {
        mainMenu.SetActive(false);
        ShowMoney(moneyShopTxt);
        shopMenu.SetActive(true);
    }

    public void OpenAuthors()
    {
        mainMenu.SetActive(false);
        authorMenu.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
