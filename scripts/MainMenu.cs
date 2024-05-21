using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Load scene
    public void Play()
    {
        SimpleTimer.targetTime = 100.0f;
        LevelLoader.Score = 0;
        LevelLoader.ElevatorStatus = false;
        LaserStatus.laserOn = false;
        LevelLoader.CurrentLevel = 2;
        Application.LoadLevel(1);
    }

    //Quit game
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }
}