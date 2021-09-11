using UnityEngine;

public class Turn : MonoBehaviour
{
    [SerializeField]
    private Camera m_Camera;

    private bool isTurn;

    private void Start()
    {
        isTurn = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Line" && !isTurn)
        {
            collision.gameObject.transform.rotation = gameObject.transform.rotation;
            isTurn = true;
        }
    }
}
