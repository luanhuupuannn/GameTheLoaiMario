using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class move : MonoBehaviour
{

    public GameObject sGameover;
    public Text textsc;
    int m_score;

    private float _immortalTime = 0f;
    public hpplayer hpplayer;
    public float nowhp;
    public float maxhp = 10;
    private Vector3 initialPosition;
    public float move1;
    int speed = 10;
    private int flip;
    private Animator anim;
    private Rigidbody2D up;
    private int height;
    public bool jump;


    public AudioSource audioSource;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {

        audioSource = GetComponent<AudioSource>();


        _immortalTime = 0f;
        Time.timeScale = 1;

        up = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        // Lưu lại vị trí ban đầu của nhân vật
        initialPosition = transform.position;
        // cập nhật hp
        nowhp = maxhp ;
        hpplayer.updatehp(nowhp,maxhp);



    }

    // Update is called once per frame
    void Update()
    {
       
        if (_immortalTime > 0f)
        {
            _immortalTime -= Time.deltaTime;// liên tục cập nhật thời gian bất tử

           
            if (_immortalTime <= 0f) // Kiểm tra nếu thời gian bất tử đã hết
            {
                anim.SetFloat("improtants", 0);  // bất tử hết thì chạy ani
            }
        }

        //di chuyen trai phai
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move1 = -1;
   
            Vector3 flip = transform.localScale; //xuay ảnh
            flip.x = -13;
            transform.localScale = flip;
            //nếu như sang trái thì -1 nhưng sài mathf thì còn 1 chạy run
            anim.SetFloat("run", Mathf.Abs(move1));

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            move1 = 1;
            //xuay hoạt ảnh 
            Vector3 flip = transform.localScale;
            flip.x = 13;
            transform.localScale = flip;
            // nếu như chạy qua phải thì lớn hơn 0.1 hoạt ảnh run chạy
            anim.SetFloat("run",move1);
        }
        else {
            // không nhấn thì là 0 thì không chạy run
            move1 = 0;
            anim.SetFloat("run", Mathf.Abs(move1));
        } 
        transform.Translate(Vector3.right*speed*move1*Time.deltaTime);
        // nhảy 
        //Input.GetKeyDown(KeyCode.UpArrow)||
        if ( Input.GetKeyDown(KeyCode.Space) && jump) 
        {
            audioSource.PlayOneShot(clip);

            // Giảm số lần nhảy sau mỗi lần nhảy thành công
            up.AddForce(Vector2.up * 13, ForceMode2D.Impulse);
            // animation trang thai nhay
                 anim.SetFloat("jum",7);
       
            // }
        }
        else
        {
            // trang thai khong nhay
            anim.SetFloat("jum", 0);
           
        }
    }
   private void OnTriggerEnter2D(Collider2D movebox)
    {
        if (movebox.gameObject.tag == "san")
        {
            jump = true;
        }
        if (movebox.gameObject.tag == "quaman")
        {
            SceneManager.LoadScene(1);

        }

        if (movebox.gameObject.tag == "coin")
        {   
            m_score = m_score + 1;
            settext("X " + m_score);

        }
        if (movebox.gameObject.tag == "roichet")
        {
            sGameover.SetActive(true); // mở tích object
            Time.timeScale = 0;// dừng màn hình điều khiển 
        }

        if (movebox.gameObject.tag == "chuongngai" && _immortalTime <= 0f)
        {
            nowhp = nowhp - 2;
            hpplayer.updatehp(nowhp, maxhp);
            _immortalTime = 1f; // Thiết lập thời gian bất tử là 5s
            anim.SetFloat("improtants", 1);
          
            if (nowhp == 0)//hp  =0 thì hồi sinh
            {
                sGameover.SetActive(true); // mở tích object
                Time.timeScale = 0;// dừng màn hình điều khiển 

                //transform.position = initialPosition;
                //nowhp = 10;
                //hpplayer.updatehp(nowhp, maxhp);

            }



        }
        
        
           
        
      
       


    }

    private void OnTriggerExit2D(Collider2D movebox)
    {
        if (movebox.gameObject.tag == "san")
        {
            jump = false;
        }
    }
    public void settext(string txt)
    {
        if (textsc)
        {
            textsc.text = txt;
        }
    }


}
