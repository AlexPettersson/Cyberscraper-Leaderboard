using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSaver : MonoBehaviour
{
    public static Vector3 Pposition;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PC")
        {
            // Get the position of the gameObject
        Vector3 position = transform.position;
        Pposition = transform.position;

        // Print the position to the console
        Debug.Log("Position: " + position);
        }
    }
}