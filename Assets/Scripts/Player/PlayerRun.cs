using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour
{
    private PlayerStamina playerStamina;

    [SerializeField]
    private KeyCode runKey;

    private bool running;

    private void Awake()
    {        
        playerStamina = GetComponent<PlayerStamina>();
    }

    private void Start()
    {
        if (runKey == KeyCode.None) runKey = KeyCode.LeftShift;
    }

    void Update()
    {
        running = Input.GetKey(runKey);
    }

    public bool isRunning()
    {
        return running && playerStamina.isAvailable();
    }
}
