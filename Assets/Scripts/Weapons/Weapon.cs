using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField]
    protected int magazineSize;

    protected IShoot weaponShoot;
    protected IReload weaponReload;
}
