using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("You touched a box!");
    }
}
