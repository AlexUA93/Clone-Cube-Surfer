using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = new Vector3 (transform.position.x, player.transform.position.y + offset.y, transform.position.z);
    }
}
