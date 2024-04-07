using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
   // public GameObject bullet2;
    //public Transform fireadd21;
   // public Transform fireadd22;
   // public Transform fireadd23;
   // public Transform fireadd24;
   // public Transform fireadd25;


  //  public float TimeFire = 6f;
  //  public float speedfire;
   // private float timefire;


    public hpboss Hpboss;
    public float nowhpboss;
    public int maxhpboss = 100;
    public GameObject deletehpboss;

    
    // Start is called before the first frame update
    void Start()
    {
        nowhpboss = maxhpboss;
        Hpboss.updatehpboss(nowhpboss, maxhpboss);
    }

    // Update is called once per frame
    void Update()
    {
       // timefire -= Time.deltaTime;
        // khi tới thời gian nhấn Q thì bắn 
       
    }

    private void OnTriggerEnter2D(Collider2D atacboss)
    {
        if (atacboss.gameObject.tag == "playerbullet")
        {
             nowhpboss -= 1;
            Hpboss.updatehpboss(nowhpboss, maxhpboss);


        }
       //  if (nowhpboss < 50)
     //   {
         //   nguongmautuboss();
      //  }
       
         if(nowhpboss < 0)
        {
        Destroy(this.gameObject);
            Destroy(deletehpboss);
            

        }

    }

   // void nguongmautuboss()
   // {
        // tạo một viện đạn 
      //  timefire = TimeFire;
      //  GameObject butllettmp21 = Instantiate(bullet2, fireadd21.position, Quaternion.identity);
       // GameObject butllettmp22 = Instantiate(bullet2, fireadd22.position, Quaternion.identity);
       // GameObject butllettmp23 = Instantiate(bullet2, fireadd23.position, Quaternion.identity);
       // GameObject butllettmp24 = Instantiate(bullet2, fireadd24.position, Quaternion.identity);
      //  GameObject butllettmp25 = Instantiate(bullet2, fireadd25.position, Quaternion.identity);


        // lực viên đạn chạy 
       // Rigidbody2D rb21 = butllettmp21.GetComponent<Rigidbody2D>();
       // Rigidbody2D rb22 = butllettmp22.GetComponent<Rigidbody2D>();
       // Rigidbody2D rb23 = butllettmp23.GetComponent<Rigidbody2D>();
       // Rigidbody2D rb24 = butllettmp24.GetComponent<Rigidbody2D>();
       // Rigidbody2D rb25 = butllettmp25.GetComponent<Rigidbody2D>();

       // rb21.AddForce(Vector2.down * speedfire, ForceMode2D.Impulse);
        //rb22.AddForce(Vector2.down * speedfire, ForceMode2D.Impulse);
       // rb23.AddForce(Vector2.down * speedfire, ForceMode2D.Impulse);
       // rb24.AddForce(Vector2.down * speedfire, ForceMode2D.Impulse);
       // rb25.AddForce(Vector2.down * speedfire, ForceMode2D.Impulse);
   // }
}
