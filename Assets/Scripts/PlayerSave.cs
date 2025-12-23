using UnityEngine;

// Controls saving and loading player data
public class PlayerSave : MonoBehaviour
{
    private PlayerStats playerStats;

    void Start()
    {
        playerStats = GetComponent<PlayerStats>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            SaveGame();

        if (Input.GetKeyDown(KeyCode.L))
            LoadGame();
    }

    void SaveGame()
    {
        SaveData data = new SaveData();

        data.posX = transform.position.x;
        data.posY = transform.position.y;
        data.posZ = transform.position.z;

        data.health = playerStats.GetHealth();
        data.coins = CoinManager.instance.GetCoins();

        SaveSystem.Save(data);
    }

    void LoadGame()
    {
        SaveData data = SaveSystem.Load();
        if (data == null) return;

        transform.position = new Vector3(data.posX, data.posY, data.posZ);
        playerStats.SetHealth(data.health);
        CoinManager.instance.SetCoins(data.coins);
    }
}