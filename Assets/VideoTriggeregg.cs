using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class VideoTriggerEgg : MonoBehaviour
{
    public Canvas videoCanvasegg;
    public UnityEngine.Video.VideoPlayer videoPlayeregg;

    public UnityEngine.AudioSource audioPlayeregg;


    private void Start()
    {
        if (videoPlayeregg != null)
        {
            videoPlayeregg.Stop(); // Ensure video is reset
            audioPlayeregg.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            videoCanvasegg.enabled = true;

            if (videoPlayeregg != null)
            {
                videoPlayeregg.Play();
                audioPlayeregg.Play();

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            videoCanvasegg.enabled = false;

            if (videoPlayeregg != null)
            {
                videoPlayeregg.Stop(); // Optional: or use .Pause() if you want to resume late
                audioPlayeregg.Stop();
                videoPlayeregg.time = 0; // Reset to start
                audioPlayeregg.time = 0;

            }
        }
    }
}