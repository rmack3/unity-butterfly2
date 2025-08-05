using UnityEngine;

public class VideoTriggerCat : MonoBehaviour
{
    public Canvas videoCanvascat;
    public UnityEngine.Video.VideoPlayer videoPlayercat;
    public UnityEngine.AudioSource audioPlayercat;

    private void Start()
    {
        if (videoCanvascat != null)
            videoCanvascat.enabled = false;

        if (videoPlayercat != null)
            videoPlayercat.Stop();

        if (audioPlayercat != null)
            audioPlayercat.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (videoCanvascat != null)
                videoCanvascat.enabled = true;

            if (videoPlayercat != null)
                videoPlayercat.Play();

            if (audioPlayercat != null)
                audioPlayercat.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (videoCanvascat != null)
                videoCanvascat.enabled = false;

            if (videoPlayercat != null)
            {
                videoPlayercat.Stop();
                videoPlayercat.time = 0;
            }

            if (audioPlayercat != null)
            {
                audioPlayercat.Stop();
                audioPlayercat.time = 0;
            }
        }
    }
}