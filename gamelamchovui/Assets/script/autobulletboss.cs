using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autobulletboss : MonoBehaviour
{
    public GameObject bullet;
    public Transform fireadd1;
    public Transform fireadd2;
    public Transform fireadd3;
    public Transform fireadd4;
    public Transform fireadd5;


    public float TimeFire = 4f;
    public float speedfire;
    private float timefire;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        timefire -= Time.deltaTime;
        // khi tới thời gian nhấn Q thì bắn 
        if ( timefire < 0)
        {
            Firebullet();
        }
    }
    
    void Firebullet()
    {
        // tạo một viện đạn 
        timefire = TimeFire;
        GameObject butllettmp1 = Instantiate(bullet, fireadd1.position, Quaternion.identity);
        GameObject butllettmp2 = Instantiate(bullet, fireadd2.position, Quaternion.identity);
        GameObject butllettmp3 = Instantiate(bullet, fireadd3.position, Quaternion.identity);
        GameObject butllettmp4 = Instantiate(bullet, fireadd4.position, Quaternion.identity);
        GameObject butllettmp5 = Instantiate(bullet, fireadd5.position, Quaternion.identity);


        // lực viên đạn chạy 
        Rigidbody2D rb1 = butllettmp1.GetComponent<Rigidbody2D>();
        Rigidbody2D rb2 = butllettmp2.GetComponent<Rigidbody2D>();
        Rigidbody2D rb3 = butllettmp3.GetComponent<Rigidbody2D>();
        Rigidbody2D rb4 = butllettmp4.GetComponent<Rigidbody2D>();
        Rigidbody2D rb5 = butllettmp5.GetComponent<Rigidbody2D>();

        rb1.AddForce(transform.right * -speedfire, ForceMode2D.Impulse);
        rb2.AddForce(transform.right * -speedfire, ForceMode2D.Impulse);
        rb3.AddForce(transform.right * -speedfire, ForceMode2D.Impulse);
        rb4.AddForce(transform.right * -speedfire, ForceMode2D.Impulse);
        rb5.AddForce(transform.right * -speedfire, ForceMode2D.Impulse);
    }
}
