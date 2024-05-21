using UnityEngine;
using UnityEngine.UI;

public class PC_1 : MonoBehaviour
{
    public AudioClip buzzer;
    public AudioClip dhm;
    public AudioClip fm;
    public AudioClip mm;
    public AudioClip nk;
    private AudioSource source;
    public bool OneKey = false;
    public bool FourKey = false;
    public bool FiveKey = false;
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
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            Debug.Log("1 key was pressed");
            OneKey = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            Debug.Log("4 key was pressed");
            FourKey = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5)) {
            Debug.Log("5 key was pressed");
            FiveKey = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6)) {
            Debug.Log("6 key was pressed");
            SixKey = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8)) {
            Debug.Log("8 key was pressed");
            EightKey = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Alpha3)) {
            Debug.Log("Wrong key was pressed");
            FourKey = false;
            SixKey = false;
            EightKey = false;
            FiveKey = false;
            OneKey = false;
                       // Assign the audio clip to the AudioSource
            source.clip = buzzer;

            // Play the audio clip
            source.Play();
        }
        if (OneKey == true && FourKey == true && FiveKey == true && SixKey == true && EightKey == true) {
            Debug.Log("All keys were pressed");
            LevelLoader.ElevatorStatus = true;
            FourKey = false;
            SixKey = false;
            EightKey = false;
            FiveKey = false;
            OneKey = false;
            Application.LoadLevel(LevelLoader.CurrentLevel);
        }
    }
}
