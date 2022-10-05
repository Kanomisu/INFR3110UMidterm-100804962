using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour
{
    //singleton instance
    public static AudioManager instance;
    AudioSource m_AudioSource;
    AudioClip m_AudioClip;
    
    
    //Debug
    bool audioPlayback = false;
    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    //Change speed of the audio clip
    public void ChangeSpeed(int audioSpeed)
    {
        //Debug lets us know if it started playing or not
        audioPlayback = true;
        Debug.Log(audioPlayback);

        //Change music to fast pace then initiate while loop to keep it like that temporarily
        //
    }

}
