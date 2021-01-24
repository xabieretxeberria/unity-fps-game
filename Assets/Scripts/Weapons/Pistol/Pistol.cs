using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    private void Awake()
    {
        weaponAudioSource = GetComponent<AudioSource>();

        if (magazineSize == 0) magazineSize = 9;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    protected override void Shoot()
    {
        RaycastHit hit;

        Physics.Raycast(shootOrigin.position, shootOrigin.forward, out hit, 50);
        Debug.DrawRay(shootOrigin.position, shootOrigin.forward * 50, Color.red);

        weaponAudioSource.Play();
    }

    protected override void Reload()
    {

    }
}
