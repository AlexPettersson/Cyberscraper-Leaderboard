using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public AudioClip ding;
    static private AudioSource ella;
    public static int Score = 0;
    public static int CurrentLevel = 2;
    public static bool ElevatorStatus = false;
    public static int Highscore = 0;
    void Start()
    {
        ella = GetComponent<AudioSource>(); // Get the AudioSource component attached to the GameObject
        if (ella == null)
        {
            // If AudioSource component is not found, add it
            ella = gameObject.AddComponent<AudioSource>();
        }
        if (CurrentLevel > 2){
                ella.clip = ding;
            
                // Play the audio clip
                ella.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (ElevatorStatus == true) {
            if (collision.gameObject.tag == "Player")
            {
                int sceneLevelIndex = Random.Range(3, 7);
                do
                {  
                    Debug.Log("Level already loaded!");
                    sceneLevelIndex = Random.Range(3, 7);
                } while (sceneLevelIndex == CurrentLevel);
                CurrentLevel = sceneLevelIndex;
                Score += 1;
                SimpleTimer.targetTime += 15;
                if (Score < 15)
                {
                SimpleTimer.targetTime -= 1 * Score;
                }
                LaserStatus.laserOn = false;
                ElevatorStatus = false;
                Application.LoadLevel(sceneLevelIndex);

            }
        }
    }
}
