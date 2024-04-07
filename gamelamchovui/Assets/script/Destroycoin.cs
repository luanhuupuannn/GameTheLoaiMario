using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroycoin : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D destroycoin)
    {
        if (destroycoin.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
    }
