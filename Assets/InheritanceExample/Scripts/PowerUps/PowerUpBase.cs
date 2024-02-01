using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    protected float powerupDuration;

    public void OnHit()
    {
        PowerUp();
        Disable();
        Invoke("PowerDown", powerupDuration);
    }

    protected abstract void PowerUp();
    protected abstract void PowerDown();

    private void Disable()
    {
        gameObject.GetComponent<Renderer>().enabled = false;

        Collider collider = GetComponent<Collider>();
        if (collider != null)
        {
            collider.enabled = false;
        }
    }

    private void OnDestroy()
    {
       
    }
}
