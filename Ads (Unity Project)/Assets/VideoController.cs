using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public void PlayVideo()
    {
        Debug.Log("Play");
        videoPlayer.Play();
    }

    public void PauseVideo()
    {
        print("Pause");
        videoPlayer.Pause();
    }
}
