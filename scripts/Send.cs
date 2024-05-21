using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Send : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Send_Score()
    {
        StartCoroutine(SendPostRequest());
    }

    private IEnumerator SendPostRequest()
    {
        string post = "\n" + LevelLoader.Score + " | " + Read_Input.name_input + " ";
        WWWForm form = new WWWForm();
        form.AddField("data", post);
        
        using (UnityWebRequest www = UnityWebRequest.Post("https://63abc309-e44c-4e38-8f5f-fedb06a8db09-00-hhzd08itb3te.worf.replit.dev/", form)) // Update the URL with your Replit app URL
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError(www.error);
            }
            else
            {
                Debug.Log("Post request sent successfully");
            }
        }
    }
}
