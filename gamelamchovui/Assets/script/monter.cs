using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monter : MonoBehaviour
{
    public float nowhpboss;
    public int maxhpboss = 10;
    private Animator ani;

    public GameObject hieuungvhet;
    // Start is called before the first frame update
    void Start()
    {
       

        ani = GetComponent<Animator>();
        nowhpboss = maxhpboss;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D atacboss)
    {
        if (atacboss.gameObject.tag == "playerbullet")
        {
            nowhpboss -= 1;
            GameObject votien = Instantiate(hieuungvhet,
             this.transform.position, this.transform.rotation);
            Destroy(votien, 1f);


        }
        //  if (nowhpboss < 50)
        //   {
        //   nguongmautuboss();
        //  }

        if (nowhpboss < 0)
        {
            //ani.SetBool("dead", true);  // cách 2 ani chết 
            // Destroy(this.gameObject);   // cách 2 ani chết 
            StartCoroutine(DestroyAfterAnimation());


        }

    }
    //void OnDeathAnimationEnd() // cách 2 ani chết 
    //{
    // Destroy(this.gameObject); // cách 2 ani chết 
    //}

    private IEnumerator DestroyAfterAnimation()
    {
       
        ani.SetBool("dead", true);
        yield return new WaitForSeconds(0.5f); // Thay thế WaitForSeconds(0.5f) bằng thời gian thực tế của animation
      Destroy(this.gameObject);
     }


}
