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
    public Text hiTxt, bestScoreTxt, rankTxt, moneyTxt;
    public GameObject player;

    void Start()
    {
        player = Instantiate(shipsPrefabs[2], DataBase.spawnPos, transform.rotation);
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
        SceneManager.LoadScene(1);
    }

    public void ShowLeaderBoard()
    {
        Social.ShowLeaderboardUI();
    }

    public void OpenShop()
    {

    }

    public void OpenAuthors()
    {

    }
}
