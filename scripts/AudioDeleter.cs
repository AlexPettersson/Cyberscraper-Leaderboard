using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDeleter : MonoBehaviour
{
    public AudioSource audioSource;
    public static bool StartSong = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SimpleTimer.targetTime <= 1)
        {
            audioSource.Stop();
        }
        else
        if (StartSong == true)
        {
            audioSource.Play();
            StartSong = false;
        }
    }
}
