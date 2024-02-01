using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    protected float powerupDuration;

    protected abstract void PowerUp();
    protected abstract void PowerDown();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            OnHit();
        }
    }
    public void OnHit()
    {
        PowerUp();
        Disable();
        Invoke("PowerDown", powerupDuration);
    }

    private void Disable()
    {
        gameObject.GetComponent<Renderer>().enabled = false;

        Collider collider = GetComponent<Collider>();
        if (collider != null)
        {
            collider.enabled = false;
        }
    }
}
