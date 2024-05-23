using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PcTp : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && LevelLoader.ElevatorStatus == false)
        {
            int scenePcIndex = Random.Range(8, 12);
            Application.LoadLevel(scenePcIndex);
        }
    }
}
