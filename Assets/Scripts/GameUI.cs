using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    private void DebugLoggingShoots()
    {
        Debug.Log("Shoot");
    }
    private void OnEnable()
    {
        GameEvents.Instance.OnShoot += DebugLoggingShoots;
    }
    private void OnDisable()
    {
        GameEvents.Instance.OnShoot -= DebugLoggingShoots;
    }
}
