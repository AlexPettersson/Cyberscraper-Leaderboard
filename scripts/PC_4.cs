using UnityEngine;
using UnityEngine.UI;

public class PC_4 : MonoBehaviour
{
    public AudioClip buzzer;
    public AudioClip dhm;
    public AudioClip fm;
    public AudioClip mm;
    public AudioClip nk;
    private AudioSource source;
    public bool SevenKey = false;
    public bool OneKey = false;
    public bool TwoKey = false;
    public bool SixKey = false;
    public bool EightKey = false;

    void Awake()
    {
        source = GetComponent<AudioSource>(); // Get the AudioSource component attached to the GameObject
        if (source == null)
        {
            // If AudioSource component is not found, add it
            source = gameObject.AddComponent<AudioSource>();
        }
        int audioRand = Random.Range(2, 6);
            if(audioRand == 2) {
                source.clip = dhm;
            }
            else if(audioRand == 3) {
                source.clip = fm;
            }
            else if(audioRand == 4) {
                source.clip = mm;
            }
            else if(audioRand == 5) {
                source.clip = nk;
            }
            
            source.Play();
    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha7)) {
            Debug.Log("7 key was pressed");
            SevenKey = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            Debug.Log("1 key was pressed");
            OneKey = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            Debug.Log("2 key was pressed");
            TwoKey = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6)) {
            Debug.Log("6 key was pressed");
            SixKey = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8)) {
            Debug.Log("8 key was pressed");
            EightKey = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Alpha0)) {
            Debug.Log("Wrong key was pressed");
            OneKey = false;
            TwoKey = false;
            SevenKey = false;
            SixKey = false;
            EightKey = false;
                       // Assign the audio clip to the AudioSource
            source.clip = buzzer;

            // Play the audio clip
            source.Play();
        }
        if (SevenKey == true && OneKey == true && TwoKey == true && SixKey == true && EightKey == true) {
            Debug.Log("All keys were pressed");
            LevelLoader.ElevatorStatus = true;
            TpAllow.TpAllowence = true;
            OneKey = false;
            TwoKey = false;
            SevenKey = false;
            SixKey = false;
            EightKey = false;
            Application.LoadLevel(LevelLoader.CurrentLevel);
        }
    }
}
