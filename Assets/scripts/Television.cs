using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Television : MonoBehaviour
{
    public Color clr = new Color(0f, 0f, 0f);
    public UnityEngine.Video.VideoClip videoClip;
    public UnityEngine.Video.VideoClip urg;
    public UnityEngine.Video.VideoClip news;
    public UnityEngine.Video.VideoClip larry;

    public int tch = 0;
    void Start()
    {
        var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
        var audioSource = gameObject.AddComponent<AudioSource>(); gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    public void videpl()
    {
        tch++;
        if (tch == 1)
        {
            //gameObject.GetComponent<UnityEngine.Video.VideoPlayer>().material.color = clr;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            // vp.Stop();
        }
        if (tch == 2)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.clip = urg;

            //gameObject.GetComponent<UnityEngine.Video.VideoPlayer>().url = "F:/Urgant.mp4";

        }
        if (tch == 3)
        {

            var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.clip = news;
            //  gameObject.GetComponent<UnityEngine.Video.VideoPlayer>().url = "F:/News.mp4";

        }
        if (tch == 4)
        {
            var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.clip = larry;
            // gameObject.GetComponent<UnityEngine.Video.VideoPlayer>().url = "F:/Larry - Short Horror Film.mp4";
            tch = 0;
        }
    }
    public void videopauase()
    {
        var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
        if (vp.isPlaying)
        {

            vp.Pause();
        }
        else
        {
            vp.Play();
        }
    }
}
