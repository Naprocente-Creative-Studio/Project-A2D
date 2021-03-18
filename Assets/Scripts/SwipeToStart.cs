using UnityEngine;

public class SwipeToStart : MonoBehaviour
{
    private const float minTimeSwipe = 0.5f;
    private const float minDistanceSwipe = 0.17f;
    private float speed = 25;
    private float upBorder =6.0f;
    public GameObject player;
    Vector2 starPos;
    float startTime;
    private GameController _game;

    private void Start()
    {
        _game = GameObject.Find("GameController").GetComponent<GameController>();
    }

    void Update()
    {
        if (Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began)
            {
                starPos = new Vector2(t.position.x / (float) Screen.width, t.position.y / (float) Screen.width);
                startTime = Time.time;
            }
            if (t.phase == TouchPhase.Ended)
            {
                Vector2 endPos = new Vector2(t.position.x / (float) Screen.width, t.position.y / (float) Screen.width);
                Vector2 swipe = new Vector2(endPos.x - starPos.x, endPos.y - starPos.y);
                if (swipe.magnitude < minDistanceSwipe) return;
                if (Mathf.Abs(swipe.x) < Mathf.Abs(swipe.y))
                {
                    if (swipe.y > 0) startPlayerAnim();
                }
            }
        }
        if(Input.GetKeyDown (KeyCode.UpArrow)) startPlayerAnim();
    }

    void startPlayerAnim()
    {
        Animator anim = GameObject.Find("Player").GetComponent<Animator>();
        anim.SetBool("isStarted", true);
        if(player.transform.position.y > upBorder) _game.StartGame();
    }
}
