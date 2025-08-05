using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class VideoTriggerButter : MonoBehaviour
{
    public Canvas videoCanvasbutter;
    public UnityEngine.Video.VideoPlayer videoPlayerbutter;

    public UnityEngine.AudioSource audioPlayerbutter;


    private void Start()
    {
        if (videoPlayerbutter != null)
        {
            videoPlayerbutter.Stop(); // Ensure video is reset
            audioPlayerbutter.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            videoCanvasbutter.enabled = true;

            if (videoPlayerbutter != null)
            {
                videoPlayerbutter.Play();
                audioPlayerbutter.Play();

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            videoCanvasbutter.enabled = false;

            if (videoPlayerbutter != null)
            {
                videoPlayerbutter.Stop(); // Optional: or use .Pause() if you want to resume late
                audioPlayerbutter.Stop();
                videoPlayerbutter.time = 0; // Reset to start
                audioPlayerbutter.time = 0;

            }
        }
    }
}
