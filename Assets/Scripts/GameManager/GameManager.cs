using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int targetMoney = 5000;
    public int currentMoney = 0;

    public TMP_Text moneyText;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }

    public void AddMoney(int amount)
    {
        currentMoney += amount;
        UpdateUI();
    }

    void UpdateUI()
    {
        moneyText.text =
            $"Собрано: {currentMoney}$ / {targetMoney}$";
    }
}