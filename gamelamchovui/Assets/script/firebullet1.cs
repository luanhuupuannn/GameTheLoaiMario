using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firebullet2  : MonoBehaviour
{

    public GameObject bullet;
    public Transform fireadd;
    public float TimeFire = 0.2f;
    public float speedfire;
    private float timefire;
    private Animator anim;



    // Start is called before the first frame update
    void Start2()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update2()
    {

        timefire -= Time.deltaTime;
        // khi tới thời gian nhấn Q thì bắn 
        if (Input.GetKey(KeyCode.Q)&& timefire < 0)
        {
            Firebullet2();
            anim.SetFloat("skill", 1);
        }
        else { anim.SetFloat("skill", 0); }
    }
    void Firebullet2()
    {
       // tạo một viện đạn 
        timefire = TimeFire;
        GameObject butllettmp = Instantiate(bullet, fireadd.position, Quaternion.identity);

        // lực viên đạn chạy 
        Rigidbody2D rb = butllettmp.GetComponent<Rigidbody2D>();

        rb.AddForce(transform.right * speedfire, ForceMode2D.Impulse);
    }

}
