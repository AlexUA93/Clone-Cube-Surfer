using System.Collections;
using UnityEngine;

public class Turn : MonoBehaviour
{
    private GameObject m_ObjectCollision;
    private Coroutine m_Coroutine;

    private bool isTurn;
    public float m_Speed = 10f;

    private void Start()
    {
        isTurn = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Line" && !isTurn)
        {
            m_ObjectCollision = collision.gameObject;
            m_Coroutine = StartCoroutine(TurnCoroutine());
            isTurn = true;
        }
    }

    IEnumerator TurnCoroutine()
    {
        while (true)
        {
            yield return new WaitForFixedUpdate();
            m_ObjectCollision.transform.rotation = Quaternion.Lerp(m_ObjectCollision.transform.rotation, gameObject.transform.rotation, m_Speed * Time.deltaTime);
            if (m_ObjectCollision.transform.rotation == gameObject.transform.rotation)
            {
                stopCurrentCoroutine();
            }
        }
    }

    private void stopCurrentCoroutine()
    {
        StopCoroutine(m_Coroutine);
    }
}
