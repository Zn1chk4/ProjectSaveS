using UnityEngine;

// Stores player health
public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int health = 100;

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int value)
    {
        health = value;
    }
}