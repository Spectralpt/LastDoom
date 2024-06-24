using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudio : MonoBehaviour
{
    private AudioSource sound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    public void playSound()
    {
        sound.Play();
    }
}
