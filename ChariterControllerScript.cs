using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{


    public float maxSpeed = 10f;
    bool facingRight = true;

    private Rigidbody2D rigi;
    private void Awake()
    {
        rigi = GetComponent<Rigidbody2D>();
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    internal void FixedUpdate()
    {

        float move = Input.GetAxis("horazontal");

        rigi.velocity = new Vector2(move * maxSpeed, rigi.velocity.y);
        if (move > 0 && !facingRight)
            flip();
        else if (move < 0 && facingRight)
            flip();


    }

    void flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;


    }



}

