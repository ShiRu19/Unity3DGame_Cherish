using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class MyVideo : MonoBehaviour
{
    public VideoPlayer vPlayer;
    public string NextScene;

    // Start is called before the first frame update
    void Start()
    {
        vPlayer.loopPointReached += EndReached;
        vPlayer.Play();
    }

    void EndReached(VideoPlayer vPlayer)
    {
        Debug.Log("End reached!");
        SceneManager.LoadScene(NextScene);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Frame " + vPlayer.frame);
    }
}
