using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public int Force;
    public bool play;
    public Transform paddle;
    public GameManager gm;
    Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Invoke(nameof(SetRandomTrajectory), 1f);
    }

    void Update()
    {
        if (!play)
        {
            transform.position = paddle.position;
        }

        if (Input.GetButtonDown("Jump"))
        {
            play = true;    
            rigid.AddForce(Vector2.up * 500);
        }
    }

    private void SetRandomTrajectory()
    {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-0.5f, 0.5f);
        force.y = -1;
        rigid.AddForce(force.normalized * Force);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Bawah"))
        {
            Debug.Log("Lu kalah");
            rigid.velocity = Vector2.zero;   
            play = false;
            gm.UpdateLife (-1);
        }
        
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.transform.CompareTag("Brick"))
        {
            Destroy (other.gameObject);
            gm.UpdateScore (+5);
        }
    }
}
