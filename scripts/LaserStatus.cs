using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserStatus : MonoBehaviour
{
    public static bool laserOn = false;
    void Start() {
        Debug.Log("Laser is on!");
    }

    void Update() {
        if (laserOn == true) {
            Debug.Log("Laser is off!");
            Destroy(gameObject);        
            }
    }
}
