using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalBox : Box
{
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("You touched a metal box!");
    }
}
