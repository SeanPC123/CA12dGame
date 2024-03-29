using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D body;
    private bool onGround;
    [SerializeField] private float playerSpeed; // lets me change the horizontal speed inside of unity
    [SerializeField] private float jumpHeight;



    private void Awake()
    {
        body = GetComponent<Rigidbody2D > ();

    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(Input.GetAxis("Horizontal")* playerSpeed ,body.velocity.y);//horizontal movement

        //flipping
        if(Input.GetAxis("Horizontal") > 0.01f)
        {
            transform.localScale = Vector3.one;
        }
        else if (Input.GetAxis("Horizontal") < -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Input.GetKey(KeyCode.Space) && onGround)
        {
            Jump();
        }
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, jumpHeight);//vertical jumping
        onGround = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            onGround = true;
        }
    }
}
