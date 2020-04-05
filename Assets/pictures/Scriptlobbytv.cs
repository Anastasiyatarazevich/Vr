using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Scriptlobbytv : MonoBehaviour
{
    public int tch = 0;
    public UnityEngine.Video.VideoClip rus;
    public UnityEngine.Video.VideoClip eng;
    public UnityEngine.Video.VideoClip videoClip;
    public AudioClip movieAudioClip;
    //public VideoClip movieTexture;
    // Start is called before the first frame update
    void Start()
    {
        var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
        var audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = movieAudioClip;
        videoPlayer.clip = videoClip;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.MaterialOverride;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void huh()
    {
        if (tch == 2) tch = 0;
        if (tch == 1)
        {
            var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
            // var audioSource = GetComponent<AudioSource>();
            videoPlayer.clip = eng;
            // GetComponent<Renderer>().material.mainTexture = eng;
            //  eng.SetActive(true);
            // rus.SetActive(false);
            tch++;
        }
        if (tch == 0)
        {
            var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.clip =rus;
            // var audioSource = GetComponent<AudioSource>();
            // GetComponent<Renderer>().material.mainTexture = rus;
            // rus.SetActive(true);
            // eng.SetActive(false);
            tch++;

        }
    }
}
