using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autobulletmonter : MonoBehaviour
{
    public GameObject bullet;
    public Transform fireadd1;
    public float TimeFire = 5f;
    public float speedfire;
    private float timefire;

    private Animator wza;

    // Start is called before the first frame update
    void Start()
    {
        wza = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        timefire -= Time.deltaTime;
        // khi tới thời gian nhấn Q thì bắn 
        if (timefire < 0)
        {
      
            Firebullet();
            wza.SetBool("wza", true);

        }
        else
        {
            wza.SetBool("wza", false);

        }
    }
    void Firebullet()
    {
        // tạo một viện đạn 
        timefire = TimeFire;
        GameObject butllettmonter = Instantiate(bullet, fireadd1.position, Quaternion.identity);


        // lực viên đạn chạy 
        Rigidbody2D rb1 = butllettmonter.GetComponent<Rigidbody2D>();

        rb1.AddForce(transform.right * -speedfire, ForceMode2D.Impulse);

    }
}
