using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    [SerializeField]
    protected TMP_Text m_CoinCounter;

    private int m_Coins;

    public void AddCoin(int value)
    {
        m_Coins += value;

        ResetCounter();
    }

    private void ResetCounter()
    {
        m_CoinCounter.text = m_Coins.ToString();
    }
}
