using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class buttonBehavior : MonoBehaviour
{
    public VideoPlayer player;
    public AudioSource clip;
    public GameObject[] gameobjects;
    

    public void PlayVideo()
    {
        player.Play();
    }

    public void PlayAudio()
    {
        clip.Play();
    }

    public void RemoveBG()
    {

    }
    public void RemoveButtons()
    {
        for (int i = 0; i < gameobjects.Length; i++)
        {
            gameobjects[i].transform.SetParent(null);
        }
    }
}
