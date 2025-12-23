using UnityEngine;
using UnityEngine.UI;

// Manages player coins
public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;

    private int coins = 0;
    public Text coinsText;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void AddCoin()
    {
        coins++;
        UpdateUI();
    }

    public int GetCoins()
    {
        return coins;
    }

    public void SetCoins(int value)
    {
        coins = value;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (coinsText != null)
            coinsText.text = "Coins: " + coins;
    }
}