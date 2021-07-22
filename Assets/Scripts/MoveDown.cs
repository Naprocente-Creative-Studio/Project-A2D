using UnityEngine;

public class MoveDown : MonoBehaviour, SpawnFromPool
{
    public bool isSharp;
    public bool isLight;
    public float speed;
    private float downBorder = -1, downBorderL = -8;
    private float sideBorder = 3;
    private float upperBorder = 12;
    private GamePlayController playController;
    private SpawnManager _spawnManager;
    public GameObject explPrefab;
    public AudioScript audioSource;

    private void Awake()
    {
        playController = GameObject.Find("GameController").GetComponent<GamePlayController>();
        _spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        audioSource = GameObject.Find("Audio Source").GetComponent<AudioScript>();
    }

    private void FixedUpdate()
    {
        if (!playController.gameOverTrigger && !playController.pauseTrigger)
        {
            gameObject.transform.Translate(0, -speed * Time.deltaTime, 0);
            if (gameObject.transform.position.y < downBorder && !isLight && !isSharp) gameObject.SetActive(false);
            if (isSharp && (gameObject.transform.position.x > sideBorder || gameObject.transform.position.x < -sideBorder || gameObject.transform.position.y > upperBorder || gameObject.transform.position.y < downBorder)) Destroy(gameObject);
            if (isLight && gameObject.transform.position.y < downBorderL) Destroy(gameObject);
        }
    }

	private void OnTriggerEnter2D(Collider2D other)
	{
        if (other.gameObject.CompareTag("Asteroids") && !isSharp && !isLight)
        {
            Instantiate(explPrefab, gameObject.transform.position, gameObject.transform.rotation);
            if(!playController.muteSound) audioSource.PlayExpl();
            gameObject.SetActive(false);
            other.gameObject.SetActive(false);
            _spawnManager.SpawnShardsAsteroids(gameObject.transform.position);
        }
    }

    public void OnPoolSpawn()
    {

    }
}
