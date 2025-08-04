using UnityEngine;

public class VideoTrigger : MonoBehaviour
{
    public Canvas videoCanvas;
    public UnityEngine.Video.VideoPlayer videoPlayer;

    private void Start()
    {
        if (videoCanvas != null)
            videoCanvas.enabled = false;

        if (videoPlayer != null)
            videoPlayer.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (videoCanvas != null)
                videoCanvas.enabled = true;

            if (videoPlayer != null)
                videoPlayer.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (videoCanvas != null)
                videoCanvas.enabled = false;

            if (videoPlayer != null)
            {
                videoPlayer.Stop();
                videoPlayer.time = 0;
            }
        }
    }
}