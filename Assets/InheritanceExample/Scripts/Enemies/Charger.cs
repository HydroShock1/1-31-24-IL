using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : EnemyBase
{

    public GameObject RapidFirePrefab;
    protected override void OnHit()
    {
        // increase speed when hit
        MoveSpeed *= 2;
    }

    public override void Kill()
    {
        if (RapidFirePrefab != null)
        {
            Instantiate(RapidFirePrefab, transform.position, Quaternion.identity);
        }
        base.Kill();
    }
 
}
