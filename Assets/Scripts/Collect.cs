using UnityEngine;
public class Collect : MonoBehaviour
{
    public GameManager m_GM;
    private float m_Up =  1f;
    private string m_NewTag = "InLine";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            m_GM.m_LineCount += 1;
            m_GM.m_Player.transform.position += new Vector3(0f, m_Up, 0f);
            collision.gameObject.transform.parent = m_GM.m_Line.transform;
            collision.gameObject.transform.localPosition = new Vector3(0f, m_Up * m_GM.m_LineCount, 0f);
            collision.gameObject.tag = m_NewTag;
        }
        if (collision.gameObject.tag == "Finish")
        {
            m_GM.m_IsFinish = true;
        }
    }
}
