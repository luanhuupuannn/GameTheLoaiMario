using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroybulltet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 2f);
    }

    private void OnTriggerEnter2D(Collider2D bulletdt)
    {
        if (bulletdt.gameObject.tag == "san") {

            Destroy(this.gameObject);
        }
        if (bulletdt.gameObject.tag == "Player")
        {

            Destroy(this.gameObject);
        }
        if (bulletdt.gameObject.tag == "playerbullet")
        {

            Destroy(this.gameObject);
        }


    }

   
}
