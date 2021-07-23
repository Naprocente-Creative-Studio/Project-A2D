using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GamePlayController playController;
	private void Start()
	{
        playController = GameObject.Find("GameController").GetComponent<GamePlayController>();
	}
	private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Comet"))
        {
            if (other.contacts[0].collider.gameObject.CompareTag("addHp")) playController.CometTrailContact(other);
        }
    }

	private void OnTriggerEnter2D(Collider2D other)
	{
        if (other.gameObject.CompareTag("Asteroids")) playController.AsteroidCollision(other);
        else if (other.gameObject.CompareTag("Asteroids1")) playController.AsteroidCollision(other);
        else if (other.gameObject.CompareTag("Asteroids2")) playController.AsteroidCollision(other);
        else if (other.gameObject.CompareTag("Comet")) playController.CometCollission(other);
        else if (other.gameObject.CompareTag("SharpAst")) playController.SharpCollision(other);
    }
}
