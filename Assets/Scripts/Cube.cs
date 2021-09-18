using UnityEngine;

public class Cube : MonoBehaviour
{
    public GameManager m_GM;
    private Transform m_Parent;
    private string m_OldTag;

    private void Awake()
    {
        m_Parent = transform.parent;
        m_OldTag = gameObject.tag;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Destroy")
        {
            m_GM.m_LineCount--;
            Destroy();
        }
    }

    public void Destroy()
    {
        transform.parent = m_Parent;
        gameObject.tag = m_OldTag;
        gameObject.active = false;
    }
}
