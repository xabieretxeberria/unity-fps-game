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
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        Physics.Raycast(ray.origin, ray.direction, out hit, 50);
        Debug.DrawRay(ray.origin, ray.direction * 50, Color.red);

        weaponAudioSource.Play();
    }

    protected override void Reload()
    {

    }
}
