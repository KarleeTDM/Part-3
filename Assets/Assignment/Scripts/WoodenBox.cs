using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenBox : Box
{
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("You touched a wooden box!");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
