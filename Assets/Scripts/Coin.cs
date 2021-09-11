using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "InLine" || collision.gameObject.tag == "Player")
        {
            gameObject.active = false;
        }
    }
}
