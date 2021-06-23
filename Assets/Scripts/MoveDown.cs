using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public bool isSharp;
    public bool isLight;
    public float speed;
    private float downBorder = -1, downBorderL = -8;
    private float sideBorder = 3;
    private float upperBorder = 12;
    private PlayerController playerScript;
    private GameController _gameController;
    private SpawnManager _spawnManager;
    public GameObject partcl;

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
            if (gameObject.transform.position.y < downBorder && !isLight && !isSharp) Destroy(gameObject);
            if (isSharp && (gameObject.transform.position.x > sideBorder || gameObject.transform.position.x < -sideBorder || gameObject.transform.position.y > upperBorder || gameObject.transform.position.y < downBorder)) Destroy(gameObject);
            if (isLight && gameObject.transform.position.y < downBorderL) Destroy(gameObject);
        }
    }

	private void OnTriggerEnter2D(Collider2D other)
	{
        if (other.gameObject.CompareTag("Asteroids") && !isSharp)
        {
            Instantiate(partcl, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
            Destroy(other.gameObject);
            _spawnManager.SpawnShardsAsteroids(gameObject.transform.position);
        }
    }
}
