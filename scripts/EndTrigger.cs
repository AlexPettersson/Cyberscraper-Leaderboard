using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public float timeRoom;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
            if(timer > timeRoom)
            {
            AudioDeleter.StartSong = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            timer = 0;
            Debug.Log("cutscene finish");
            }

            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
    }
}
