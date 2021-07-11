using System.Collections;
using UnityEngine;

public class SwipeToStart : MonoBehaviour
{
    Vector2 starPos;
    public MainMenuController controller;
    private Animation anim;
    private GameObject arrows;

    private void Start()
    {
        anim = controller.player.GetComponent<Animation>();
        arrows = controller.player.transform.GetChild(0).gameObject;
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
                        controller.audioSource.PlayStart();
                        anim.Play("StartAnim");
                    }
                    if (swipe.y < 0)
                    {
                        controller.OpenAuthors();
                    }
                }
                else if (Mathf.Abs(swipe.x) > Mathf.Abs(swipe.y))
                {
                    if (swipe.x > 0) controller.ShowLeaderBoard();
                    if (swipe.x < 0) controller.OpenShop();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            arrows.SetActive(false);
            controller.audioSource.PlayStart();
            anim.Play("StartAnim");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            controller.OpenAuthors();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            controller.OpenShop();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            controller.ShowLeaderBoard();
        }
    }
}
