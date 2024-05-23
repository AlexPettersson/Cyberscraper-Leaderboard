using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GO_Score : MonoBehaviour
{
    public TextMeshProUGUI uiGO_Score;
    void Update()
    {
        // Update the text of the UI Text component with the value of myVariable
        if (LevelLoader.Score > LevelLoader.Highscore)
        {
            LevelLoader.Highscore = LevelLoader.Score;
        }

        if (uiGO_Score != null) // Ensure the reference to uiText is not null
        {
            uiGO_Score.text = "You got to floor: " + LevelLoader.Score.ToString() + "\nYour best is: " + LevelLoader.Highscore.ToString(); // Update the text
        }
    }
}