using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject knifePrefab;
    public Transform spawnPoint1;
    public Transform spawnPoint2;

    protected override void Attack()
    {
        for (int i = 0; i < 2; i++)
        { 
            base.Attack();
            Instantiate(knifePrefab, spawnPoint1.position, spawnPoint1.rotation);
            base.Attack();
            Instantiate(knifePrefab, spawnPoint2.position, spawnPoint2.rotation);
        }
    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
}
