﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;





  


public class automove : MonoBehaviour
{
    public int speed = 10;
    private int flipmt;
    public float spf; // Tốc độ di chuyển
    public float distance = 10.0f; // Khoảng cách di chuyển

    private Vector3 startPosition; // Vị trí ban đầu

    void Start()
    {
        startPosition = transform.position; // Lưu vị trí ban đầu
        
    }

    void Update()
    {
        // Di chuyển qua lại theo trục x
        transform.Translate(Vector3.right * speed * Time.deltaTime);
           


        // Kiểm tra xem đã đạt đến điểm cuối hay chưa
        if (transform.position.x >= startPosition.x + distance ||
            transform.position.x <= startPosition.x - distance)
        {
            // Đảo ngược hướng di chuyển
            speed = -speed;
           
  if(speed <0){
            Vector3 flipmt = transform.localScale; //xuay ảnh
            flipmt.x = 10;
            transform.localScale = flipmt;
                }
        else{
              Vector3 flipmt = transform.localScale; //xuay ảnh
             flipmt.x =-10;
             transform.localScale = flipmt;
             }
        }
     
    }

 
}
