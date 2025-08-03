using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class PlayVideoOnProximity : MonoBehaviour
{
    public VideoPlayer videoPlayer;      // Assign in Inspector or auto-find
    public string targetTag = "Player";  // Tag used on player/XR Rig

    private void Start()
    {
        if (videoPlayer == null)
            videoPlayer = GetComponent<VideoPlayer>();

        if (videoPlayer != null)
            videoPlayer.Stop(); // Ensure it's not playing on start
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            if (videoPlayer != null && !videoPlayer.isPlaying)
            {
                StartCoroutine(DelayedPlay());
            }
        }
    }

    private IEnumerator DelayedPlay()
    {
        // Give Unity a frame or two to fully initialize the video render path
        yield return new WaitForSeconds(0.1f); // You can also try WaitForEndOfFrame
        videoPlayer.Play();
    }
}