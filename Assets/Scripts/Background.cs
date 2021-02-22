using UnityEngine;

public class Background : MonoBehaviour
{
    public GameController gameController;

    public PlayerController playerController;

    public float speed;

        
    private void FixedUpdate()
    {
        if (!gameController.gameIsPaused || !playerController.gameIsOver)
        {
           
        }
    }
}
