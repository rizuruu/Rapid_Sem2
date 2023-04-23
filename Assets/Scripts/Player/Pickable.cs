using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.transform.name);
        Debug.Log(collision.transform.tag);
        Debug.Log(collision.gameObject.tag);
        if (collision.transform.tag == "Player")
        {
            collision.gameObject.GetComponent<BasePlayer>().PickupHealth(1);
        }
    }
}
