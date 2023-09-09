using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
   public float speed;
   public float batasKanan;
   public float batasKiri;
    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal")* Time.deltaTime * speed;
        float nextPosX = transform.position.x + horizontal;
        if (nextPosX > batasKanan)
        {
            horizontal = 0;
        }

        if (nextPosX < batasKiri)
        {
            horizontal = 0;
        }

        transform.Translate(horizontal,0 ,0);
    }
}
