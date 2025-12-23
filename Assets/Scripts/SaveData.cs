using UnityEngine;

// Data container for saving game state
[System.Serializable]
public class SaveData
{
    public float posX;
    public float posY;
    public float posZ;

    public int health;
    public int coins;
}