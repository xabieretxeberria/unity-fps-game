using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStamina : MonoBehaviour
{
    private PlayerRun playerRun;

    [SerializeField]
    private float totalStamina;

    private float currentStamina;
    private bool available;

    private void Awake()
    {
        playerRun = GetComponent<PlayerRun>();
    }

    private void Start()
    {
        currentStamina = totalStamina;
        available = true;
    }

    private void Update()
    {
        if (!available) return;
        if (!playerRun.isRunning()) return;

        currentStamina -= Time.deltaTime;

        if (currentStamina <= 0f) StartCoroutine(waitAndRecover());
    }

    private IEnumerator waitAndRecover()
    {
        available = false;

        yield return null;

        available = true;
    }

    public bool isAvailable()
    {
        return available;
    }
}
