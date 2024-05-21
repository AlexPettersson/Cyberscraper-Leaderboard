using UnityEngine;

public class SimpleTimer : MonoBehaviour
{
    public static SimpleTimer Instance;

    public static float targetTime = 20.0f;

    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime < 1.0f)
        {
            timerEnded();
        }
    }

    void timerEnded()
    {
        Application.LoadLevel("GO");
        Debug.Log("Timer has ended!");
        // Handle what to do when the timer ends
    }
}
