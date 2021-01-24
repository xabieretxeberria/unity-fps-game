using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public abstract class Weapon : MonoBehaviour
{
    [SerializeField]
    protected int magazineSize;

    [SerializeField]
    protected Transform shootOrigin;

    protected AudioSource weaponAudioSource;

    protected abstract void Shoot();

    protected abstract void Reload();
}
