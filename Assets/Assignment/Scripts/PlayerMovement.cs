using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D rb;
    public float force;
    public float jump;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }
    private void FixedUpdate()
    {
        rb.AddForce(direction * force * Time.deltaTime);
        if (direction.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (direction.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
