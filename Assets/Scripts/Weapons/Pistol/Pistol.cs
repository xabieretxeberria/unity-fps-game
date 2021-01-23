using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    private void Awake()
    {
        if (magazineSize == 0) magazineSize = 9;

        weaponShoot = GetComponent<PistolShoot>();
        weaponReload = GetComponent<PistolReload>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            weaponShoot.Shoot();
        }
    }
}
