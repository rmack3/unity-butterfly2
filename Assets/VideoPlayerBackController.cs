using UnityEngine;
using UnityEngine.Video;
using System.Collections;

public class VideoPlaybackController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        StartCoroutine(PlayPreparedVideo());
    }

    IEnumerator PlayPreparedVideo()
    {
        videoPlayer.Prepare();
        while (!videoPlayer.isPrepared)
        {
            yield return null;
        }

        videoPlayer.Play();
    }
}