using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 6.0f;
    public float damage = 25;
    public bool isSharp;
    private float downBorder = -6;
    private float sideBorder = 3;
    private float upperBorder = 10;
    private PlayerController playerScript;
    private GameController _gameController;
    private SpawnManager _spawnManager;

    private void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        _gameController = GameObject.Find("GameController").GetComponent<GameController>();
        _spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    private void FixedUpdate()
    {
        if (!playerScript.gameIsOver && !_gameController.gameIsPaused)
        {
            gameObject.transform.Translate(0, -speed * Time.deltaTime, 0);
            if (gameObject.transform.position.y < downBorder || gameObject.transform.position.x > sideBorder || gameObject.transform.position.x < -sideBorder || gameObject.transform.position.y > upperBorder) Destroy(gameObject);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Asteroids") && !isSharp)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            _spawnManager.SpawnShardsAsteroids(gameObject.transform.position);
        }
    }
}
