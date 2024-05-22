using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoScene : MonoBehaviour
{
    public VideoPlayer player;
    public Button finish_button;
    public GameObject finishButton;
 
    private void Start()
    {
        player.loopPointReached += ShowButton;
    }

    void ShowButton(UnityEngine.Video.VideoPlayer vp)

    {
        finishButton.SetActive(true);
//        finish_button.transform.SetParent(GameObject.FindAnyObjectByType<Canvas>().transform, false);
    }
}
