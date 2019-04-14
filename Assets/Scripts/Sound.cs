using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public static Sound soundInstance = null;
    public static Sound getSoundInstance
    {
        get { return soundInstance; }
    }

    // Use this for initialization
    private void Awake()
    {
        if (soundInstance != null && soundInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            soundInstance = this;
        }


        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        var audioSource = this.GetComponent<AudioSource>();
        if (audioSource.clip.name == "MainGameSound")
        {
            if (Time.time >= 20)
            {
                audioSource.pitch = 1.05f;
            }
            if (Time.time >= 40)
            {
                audioSource.pitch = 1.1f;
            }
            if (Time.time >= 60)
            {
                audioSource.pitch = 1.15f;
            }
            if (Time.time >= 75)
            {
                audioSource.pitch = 1.2f;
            }
            if (Time.time >= 90)
            {
                audioSource.pitch = 1.25f;
            }
            if (Time.time >= 100)
            {
                audioSource.pitch = 1.3f;
            }
        }
    }

}
