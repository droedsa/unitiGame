using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManenger : MonoBehaviour
{
    static AudioClip soundJump, soundDead, soundBoost, platformCrash;

    static AudioSource audioSrc;

    void Start()
    {
        soundJump = Resources.Load<AudioClip>("jump");
        soundDead = Resources.Load<AudioClip>("pada");
        soundBoost = Resources.Load<AudioClip>("feder");
        platformCrash = Resources.Load<AudioClip>("lomise");


        audioSrc = GetComponent<AudioSource>(); 
    }


    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "jump":
                audioSrc.PlayOneShot(soundJump);
                break;
            case "pada":
                audioSrc.PlayOneShot(soundDead);
                break;
            case "feder":
                audioSrc.PlayOneShot(soundBoost);
                break;
            case "lomise":
                audioSrc.PlayOneShot(platformCrash);
                break;



        }
    }

}
