using System.Collections;
using UnityEngine;

public class PlayerStamina : MonoBehaviour
{
    private PlayerRun playerRun;

    [SerializeField]
    private float totalStamina;

    [SerializeField]
    private float staminaCost;

    // Variables de control
    private float currentStamina;
    private float staminaPercentage;
    private bool available;

    //UI
    [SerializeField]
    private RectTransform staminaBarRT;

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

        currentStamina -= staminaCost * Time.deltaTime;

        if (currentStamina <= 0f) StartCoroutine(waitAndRecover());
    }

    private void OnGUI()
    {
        staminaPercentage = Mathf.Clamp(currentStamina / totalStamina, 0f, 1f);
        staminaBarRT.localScale = new Vector3(staminaPercentage, 1, 1);
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
