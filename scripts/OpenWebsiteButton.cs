using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Diagnostics;

public class OpenWebsiteButton : MonoBehaviour, IPointerClickHandler
{
    public string websiteURL = "https://63abc309-e44c-4e38-8f5f-fedb06a8db09-00-hhzd08itb3te.worf.replit.dev/";

    public void OnPointerClick(PointerEventData eventData)
    {
        // Check if the URL is valid
        if (!string.IsNullOrEmpty(websiteURL))
        {
            // Open the website in the default web browser
            OpenURL(websiteURL);
        }
        else
        {
            UnityEngine.Debug.LogError("Website URL is not set!");
        }
    }

    // Function to open the URL in the default web browser
    void OpenURL(string url)
    {
        // Start a new process to open the URL
        Process.Start(url);
    }
}
