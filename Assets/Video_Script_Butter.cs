using UnityEngine;

public class VideoTriggerButter : MonoBehaviour
{
    public Canvas videoCanvasbutter;
    public UnityEngine.Video.VideoPlayer videoPlayerbutter;
    public UnityEngine.AudioSource audioPlayerbutter;

    private void Start()
    {
        if (videoCanvasbutter != null)
            videoCanvasbutter.enabled = false;

        if (videoPlayerbutter != null)
            videoPlayerbutter.Stop();

        if (audioPlayerbutter != null)
            audioPlayerbutter.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (videoCanvasbutter != null)
                videoCanvasbutter.enabled = true;

            if (videoPlayerbutter != null)
                videoPlayerbutter.Play();

            if (audioPlayerbutter != null)
                audioPlayerbutter.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (videoCanvasbutter != null)
                videoCanvasbutter.enabled = false;

            if (videoPlayerbutter != null)
            {
                videoPlayerbutter.Stop();
                videoPlayerbutter.time = 0;
            }

            if (audioPlayerbutter != null)
            {
                audioPlayerbutter.Stop();
                audioPlayerbutter.time = 0;
            }
        }
    }
}