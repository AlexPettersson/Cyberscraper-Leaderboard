using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSwitch : MonoBehaviour
{
    public AudioClip trail;
    private AudioSource error;
    void Start()
    {
        error = GetComponent<AudioSource>(); // Get the AudioSource component attached to the GameObject
        if (error == null)
        {
            // If AudioSource component is not found, add it
            error = gameObject.AddComponent<AudioSource>();
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LaserStatus.laserOn = true;
            Debug.Log("Switch is touched!");
            error.clip = trail;
            error.Play();
        }
    }
}
