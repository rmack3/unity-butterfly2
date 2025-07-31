using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class VideoTrigger : MonoBehaviour
{
    public Canvas videoCanvas;
    public UnityEngine.Video.VideoPlayer videoPlayer;

    public UnityEngine.AudioSource audioPlayer;


    private void Start()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Stop(); // Ensure video is reset
            audioPlayer.Stop();
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
                audioPlayer.Play();

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
                audioPlayer.Stop();
                videoPlayer.time = 0; // Reset to start
                audioPlayer.time = 0;

            }
        }
    }
}
