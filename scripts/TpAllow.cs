using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpAllow : MonoBehaviour
{
    public static bool TpAllowence = false;

    // Update is called once per frame
    void Update()
    {
        if(LevelLoader.ElevatorStatus == true && TpAllowence == true)
        {
            transform.position = PositionSaver.Pposition;
            TpAllowence = false;
        }
    }
}
