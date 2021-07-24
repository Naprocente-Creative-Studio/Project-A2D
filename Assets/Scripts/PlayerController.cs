using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GamePlayController playController;
	private void Start()
	{
        playController = GameObject.Find("GameController").GetComponent<GamePlayController>();
	}

	private void FixedUpdate()
	{
        if (gameObject.transform.position.y < 0) gameObject.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z);
        if (gameObject.transform.position.y > 10) gameObject.transform.position = new Vector3(gameObject.transform.position.x, 10, gameObject.transform.position.z);
        if (gameObject.transform.position.x < -2.5f) gameObject.transform.position = new Vector3(-2.5f, gameObject.transform.position.y, gameObject.transform.position.z);
        if (gameObject.transform.position.x > 2.5f) gameObject.transform.position = new Vector3(2.5f, gameObject.transform.position.y, gameObject.transform.position.z);
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
