using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBehavior : MonoBehaviour
{
    float currentCooldown;
    // Start is called before the first frame update
    void Start()
    {
        currentCooldown = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCooldown();
    }

    void UpdateCooldown()
    {
        if (!CanShoot())
        {
            currentCooldown = currentCooldown - Time.deltaTime;
        }
    }

    protected void ResetCooldown()
    {
        currentCooldown = 1f;
    }

    public abstract void Shoot();
    public abstract float GetKnockback();

    public bool CanShoot()
    {
        return (currentCooldown <= 0f);
    }
}
