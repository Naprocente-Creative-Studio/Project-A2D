using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    void Start()
    {
        ÀuthenticationGoogle();
    }

    void ÀuthenticationGoogle()
    {
        PlayGamesPlatform.Activate();
        PlayGamesPlatform.Instance.Authenticate(SignInInteractivity.CanPromptOnce, (result) => { });
        StartCoroutine(PlayIntro());
    }

    IEnumerator PlayIntro()
    {

        yield return new WaitForSeconds(3.8f);

        SceneManager.LoadScene(1);
    }
}
