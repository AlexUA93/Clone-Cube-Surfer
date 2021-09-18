using System.Collections;
using System.Linq;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private GameObject m_Line;
    [SerializeField]
    private CoinCounter m_CoinCounter;
    private Transform[] m_Cube;
    private Cube m_CC;
    private int m_CubeCount = 0;
    private bool isCollision = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Line" && !isCollision)
        {
            m_Line = collision.gameObject;
            isCollision = true;
            Win();
        }
    }

    private void Win()
    {
        m_Cube = m_Line.GetComponentsInChildren<Transform>();
        for (int i = 0; i < m_Cube.Length; i++)
        {
            if (m_Cube[i].gameObject.tag == "InLine")
            {
                m_CC = m_Cube[i].gameObject.GetComponent<Cube>();
                m_CC.Destroy();
                m_CubeCount++;
            }
        }

        m_CoinCounter.AddCoin(m_CubeCount);
    }
}
