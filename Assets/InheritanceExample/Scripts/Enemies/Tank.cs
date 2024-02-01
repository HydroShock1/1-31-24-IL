using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : EnemyBase
{
    protected override void OnHit()
    {
        StartCoroutine(PauseAndResume());
    }

    IEnumerator PauseAndResume()
    {
        float tempMoveSpeed = MoveSpeed;
        MoveSpeed = 0;
        yield return new WaitForSeconds(1.0f);
        MoveSpeed = tempMoveSpeed;
    }    
}
