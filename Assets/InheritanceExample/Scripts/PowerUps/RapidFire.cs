using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFire : PowerUpBase
{
    private TurretController turretController;
    private float originalCooldown;

    private void Start()
    {
        turretController = FindObjectOfType<TurretController>();
    }

    protected override void PowerUp()
    {
        if (turretController != null)
        {
            originalCooldown = turretController.FireCooldown;

            turretController.FireCooldown /= 2f;
        }
    }

    protected override void PowerDown()
    {
        if (turretController != null)
        {
            turretController.FireCooldown = originalCooldown;
        }
    }
}
