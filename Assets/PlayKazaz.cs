using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayKazaz : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    Ray ray;
    RaycastHit hit;
    
    void Awake()
    {
        //videoPlayer = GetComponent<VideoPlayer> ();
    }

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.Play();
        videoPlayer.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag == "kazaz") 
                {
                    Debug.Log("TAP");
                    if(videoPlayer.isPlaying)
                    {
                        videoPlayer.Pause();
                    }
                    else
                    {
                        videoPlayer.Play();
                    }

                }
            }
        }
    }
}
