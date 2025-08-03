using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class PlayVideoOnClick : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private void Awake()
    {
        // Optional: auto-assign if on same object
        if (videoPlayer == null)
            videoPlayer = GetComponent<VideoPlayer>();

        if (videoPlayer != null)
            videoPlayer.Stop(); // Start paused

        // Subscribe to interactable event
        var interactable = GetComponent<XRBaseInteractable>();
        if (interactable != null)
        {
            interactable.selectEntered.AddListener(OnSelected);
        }
    }

    private void OnSelected(SelectEnterEventArgs args)
    {
        if (videoPlayer != null && !videoPlayer.isPlaying)
        {
            videoPlayer.Play();
            Debug.Log("Video started.");
        }
    }
}
