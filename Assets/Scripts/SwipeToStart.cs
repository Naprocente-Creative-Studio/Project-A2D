using System.Collections;
using UnityEngine;

public class SwipeToStart : MonoBehaviour
{
    public GameObject player;
    Vector2 starPos;
    private GameController _game;
    private Animation anim;
    public GameObject arrows;

    private void Start()
    {
        _game = GameObject.Find("GameController").GetComponent<GameController>();
        anim = player.GetComponent<Animation>();
    }

    void Update()
    {
        if (Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began)
            {
                starPos = new Vector2(t.position.x / (float) Screen.width, t.position.y / (float) Screen.width);
            }
            if (t.phase == TouchPhase.Ended)
            {
                Vector2 endPos = new Vector2(t.position.x / (float) Screen.width, t.position.y / (float) Screen.width);
                Vector2 swipe = new Vector2(endPos.x - starPos.x, endPos.y - starPos.y);
                if (Mathf.Abs(swipe.x) < Mathf.Abs(swipe.y))
                {
                    if (swipe.y > 0)
                    {
                        arrows.SetActive(false);
                        StartCoroutine(startPlayerAnim());
                    }
                    if (swipe.y < 0)
                    {
                        _game.OpenMap();
                    }
                }
                else if (Mathf.Abs(swipe.x) > Mathf.Abs(swipe.y))
                {
                    if (swipe.x > 0) _game.ShowLeaderBoard();
                    if (swipe.x < 0) _game.OpenSettings();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            arrows.SetActive(false);
            StartCoroutine(startPlayerAnim());
        }
    }

    IEnumerator startPlayerAnim()
    {
        anim.Play("StartAnim");
        while (anim.isPlaying)
        {
            yield return null;
        }
        _game.StartGame();
    }
}
