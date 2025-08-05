using UnityEngine;

public class VideoTriggerEgg : MonoBehaviour
{
    public Canvas videoCanvasegg;
    public UnityEngine.Video.VideoPlayer videoPlayeregg;
    public UnityEngine.AudioSource audioPlayeregg;

    private void Start()
    {
        if (videoCanvasegg != null)
            videoCanvasegg.enabled = false;

        if (videoPlayeregg != null)
            videoPlayeregg.Stop();

        if (audioPlayeregg != null)
            audioPlayeregg.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (videoCanvasegg != null)
                videoCanvasegg.enabled = true;

            if (videoPlayeregg != null)
                videoPlayeregg.Play();

            if (audioPlayeregg != null)
                audioPlayeregg.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (videoCanvasegg != null)
                videoCanvasegg.enabled = false;

            if (videoPlayeregg != null)
            {
                videoPlayeregg.Stop();
                videoPlayeregg.time = 0;
            }

            if (audioPlayeregg != null)
            {
                audioPlayeregg.Stop();
                audioPlayeregg.time = 0;
            }
        }
    }
}