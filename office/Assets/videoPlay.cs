using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class videoPlay : MonoBehaviour
{
    public GameObject letter;
    public VideoPlayer video_play;

    // Start is called before the first frame update
    void Start()
    {
        video_play.loopPointReached += EndReached;
        video_play.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void EndReached(VideoPlayer vPlayer)
    {
        Debug.Log("End reached!");
        SceneManager.LoadScene("EndingBlackSpace");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "MarryLetter")
        {
            video_play.enabled = true;
            video_play.Play();
        }
    }
}
