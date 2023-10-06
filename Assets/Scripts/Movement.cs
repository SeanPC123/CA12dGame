using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float playerSpeed; // lets me change the horizontal speed inside of unity

    private void Awake()
    {
        body = GetComponent<Rigidbody2D > ();

    }

    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal")* playerSpeed ,body.velocity.y);
    }
}
