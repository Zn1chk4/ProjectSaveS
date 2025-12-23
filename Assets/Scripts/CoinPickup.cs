using UnityEngine;

// Script for picking up coins
public class CoinPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CoinManager.instance.AddCoin();
            Destroy(gameObject);
        }
    }
}