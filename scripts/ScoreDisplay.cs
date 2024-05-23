using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI uiScore;
    void Update()
    {
        // Update the text of the UI Text component with the value of myVariable
        if (uiScore != null) // Ensure the reference to uiText is not null
        {
            uiScore.text = "Floor: " + LevelLoader.Score.ToString(); // Update the text
        }
    }
}
