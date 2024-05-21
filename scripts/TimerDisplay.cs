using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerDisplay : MonoBehaviour
{
    public TextMeshProUGUI uiText;
    void Update()
    {
        // Update the text of the UI Text component with the value of myVariable
        if (uiText != null) // Ensure the reference to uiText is not null
        {
            uiText.text = "Time: " + SimpleTimer.targetTime.ToString("N0"); // Update the text
        }
    }
}
