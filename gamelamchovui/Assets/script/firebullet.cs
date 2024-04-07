using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firebullet : MonoBehaviour
{

   

    public GameObject bullet;
    public Transform fireadd;
    public float TimeFire = 0.6f;
    public float speedfire;
    private float timefire;
    private Animator anim;

    public int firelip;


    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float scaleX = transform.localScale.x;

        timefire -= Time.deltaTime;

        // khi tới thời gian nhấn Q thì bắn 
        if (Input.GetKey(KeyCode.Q) && timefire < 0 && scaleX < 0)
        {
            Firebulletleft();
            anim.SetFloat("skill", 1);

        }

        if (Input.GetKey(KeyCode.Q)&& timefire < 0 && scaleX > 0)
        {
            Firebulletright();
            anim.SetFloat("skill",1);
        }
      
        else {
        
            anim.SetFloat("skill", 0);
        }
    }

    void Firebulletright()
    {
            // tạo một viện đạn 
            timefire = TimeFire;
            GameObject butllettmp = Instantiate(bullet, fireadd.position, Quaternion.identity);

        // lực viên đạn chạy 
        Rigidbody2D rb = butllettmp.GetComponent<Rigidbody2D>();

            rb.AddForce(transform.right * speedfire, ForceMode2D.Impulse);
      
      
    }
    void Firebulletleft()
    {

        // tạo một viện đạn 
        timefire = TimeFire;
        GameObject butllettmp = Instantiate(bullet, fireadd.position, Quaternion.identity);

        // lực viên đạn chạy 
        Rigidbody2D rb = butllettmp.GetComponent<Rigidbody2D>();

        rb.AddForce(transform.right * -speedfire, ForceMode2D.Impulse);


    }

}
