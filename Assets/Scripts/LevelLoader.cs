using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator anim;
    public float transition = 2f;

    public void LoadLevel(int levelIndex)
    {
        StartCoroutine(Loading(levelIndex));
    }

    IEnumerator Loading(int levelIndex)
    {
        anim.SetTrigger("Start");

        yield return new WaitForSeconds(transition);

        SceneManager.LoadScene(levelIndex);
    }
}
