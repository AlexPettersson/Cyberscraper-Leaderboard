using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class powerUp : MonoBehaviour
{
    public TextMeshProUGUI powerUpText;
    void Update(){
        if(LevelLoader.ElevatorStatus == true){
            if (powerUpText != null) // Ensure the reference to uiText is not null
            {
                powerUpText.text = "Power UP!";
            }
        }

    }
}
