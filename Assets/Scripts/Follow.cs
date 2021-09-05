using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    private Vector3 rotation;

    private void Awake()
    {
        rotation = transform.eulerAngles;
    }
    void Start()
    {
        offset = transform.position - player.transform.position;
        transform.eulerAngles = rotation;

    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
