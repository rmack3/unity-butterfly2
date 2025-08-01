using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class VideoTrigger : MonoBehaviour
{
    public Canvas videoCanvascat;
    public UnityEngine.Video.VideoPlayer videoPlayercat;

    public UnityEngine.AudioSource audioPlayercat;


    private void Start()
    {
        if (videoPlayercat != null)
        {
            videoPlayercat.Stop(); // Ensure video is reset
            audioPlayercat.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            videoCanvascat.enabled = true;

            if (videoPlayercat != null)
            {
                videoPlayercat.Play();
                audioPlayercat.Play();

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            videoCanvascat.enabled = false;

            if (videoPlayercat != null)
            {
                videoPlayercat.Stop(); // Optional: or use .Pause() if you want to resume late
                audioPlayercat.Stop();
                videoPlayercat.time = 0; // Reset to start
                audioPlayercat.time = 0;

            }
        }
    }
}
