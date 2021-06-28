[System.Serializable]
public class PlayerData
{
	public int score = 0;
	public int money = 0;

	public PlayerData(PlayerController player)
	{
		score = player.score;
		money = player.money;
	}

	public PlayerData()
	{
	}
}
