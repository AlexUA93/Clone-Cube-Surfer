using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    protected CoinCounter m_CC;

    protected bool m_IsCount;

    private void OnCollisionEnter(Collision collision)
    {
        if (!m_IsCount  && (collision.gameObject.tag == "InLine" || collision.gameObject.tag == "Player"))
        {
            m_IsCount = true;
            m_CC.AddCoin(1);
            gameObject.active = false;
        }
    }
}
