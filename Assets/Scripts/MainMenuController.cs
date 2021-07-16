using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System.Collections;
using UnityEngine;
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
    public Material engMaterial;
    public AudioScript audioSource;
    public bool muteSound;
    public AudioSource mainMenuSound;

    void Start()
    {
        StartMainMenu();
    }

    void StartMainMenu()
    {
        muteSound = intToBool(PlayerPrefs.GetInt("Sound"));
        if (muteSound) mainMenuSound.Stop();
        mainMenu.SetActive(true);
        engMaterial.color = DataBase.flameColors[Random.Range(0, DataBase.flameColors.Length)];
        player = Instantiate(shipsPrefabs[PlayerPrefs.GetInt("ShipIndex", 0)], DataBase.spawnPos, transform.rotation);
        Instantiate(levelPrefabs[Random.Range(0, levelPrefabs.Length)], DataBase.levelMPos, transform.rotation);
        ShowMoney(moneyTxt);
        ÀuthenticationGoogle();
    }

    void ÀuthenticationGoogle()
    {
        PlayGamesPlatform.Activate();
        PlayGamesPlatform.Instance.Authenticate(SignInInteractivity.CanPromptOnce, (result) => { });
        StartCoroutine(StatsShow());
    }

    public void StartGame()
    {
        levelLoader.GetComponent<LevelLoader>().LoadLevel(2);
    }

    public void ShowMoney(Text money)
    {
        money.text = "" + PlayerPrefs.GetInt("Money");
        Debug.Log(PlayerPrefs.GetInt("Money"));
    }

    public void ShowLeaderBoard()
    {
        if (!muteSound) audioSource.PlayMenu();
        Social.ShowLeaderboardUI();
    }

    public void OpenShop()
    {
        if (!muteSound) audioSource.PlayMenu();
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
        if (!muteSound) audioSource.PlayMenu();
        mainMenu.SetActive(false);
        swipeDetector.SetActive(false);
        player.GetComponent<Animation>().Stop();
        player.transform.GetChild(0).gameObject.SetActive(false);
        starPartclObject.GetComponent<ParticleSystem>().Pause();
        authorMenu.SetActive(true);
    }

    public void MainMenu()
    {
        if(!muteSound) audioSource.PlayMenu();
        levelLoader.GetComponent<LevelLoader>().LoadLevel(1);
    }

    public void OpenInst()
    {
        if (!muteSound) audioSource.PlayMenu();
        Application.OpenURL("https://www.instagram.com/interesi_studio/");
    }

    public void OpenLinkedIn()
    {
        if (!muteSound) audioSource.PlayMenu();
        Application.OpenURL("https://www.linkedin.com/company/interesi-studio/");
    }

    public void OpenEngSupport()
    {
        if (!muteSound) audioSource.PlayMenu();
        Application.OpenURL("https://forms.gle/3NueSkcmzyMvWUp79");
    }

    public void OpenRusSupport()
    {
        if (!muteSound) audioSource.PlayMenu();
        Application.OpenURL("https://forms.gle/pbcmLew8mXkpyPQG9");
    }

    public void MuteSound()
    {
        muteSound = !muteSound;
        if(muteSound) mainMenuSound.Stop();
        if (!muteSound) mainMenuSound.Play();
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

    IEnumerator StatsShow()
    {
        yield return new WaitForSeconds(2f);
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
}
