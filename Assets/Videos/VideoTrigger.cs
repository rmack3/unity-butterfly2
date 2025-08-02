using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class VideoTrigger : MonoBehaviour
{
    public Canvas videoCanvas;
    public UnityEngine.Video.VideoPlayer videoPlayer;



    private void Start()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Stop(); // Ensure video is reset
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            videoCanvas.enabled = true;

            if (videoPlayer != null)
            {
                videoPlayer.Play();

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            videoCanvas.enabled = false;

            if (videoPlayer != null)
            {
                videoPlayer.Stop(); // Optional: or use .Pause() if you want to resume late
                videoPlayer.time = 0; // Reset to start

            }
        }
    }
}
