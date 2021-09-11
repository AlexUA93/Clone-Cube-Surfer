using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject m_Player;
    public GameObject m_Line;
    private PlayerControle m_PlayerControle;

    public float speed = 5f;
    public int m_LineCount = 0;
    public bool m_IsFinish;

    private void Awake()
    {
        m_PlayerControle = new PlayerControle();
        m_PlayerControle.GamePlay.MoveByMouse.performed += ctx => MoveLR();
        m_IsFinish = false;
    }

    private void MoveLR()
    {
        m_Line.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (!m_IsFinish)
        {
            m_Line.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
