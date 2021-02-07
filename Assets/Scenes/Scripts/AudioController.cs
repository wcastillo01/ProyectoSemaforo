using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.time = 21;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.M))
        {
            audioSource.Pause();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            audioSource.UnPause();
        }



    }
}
