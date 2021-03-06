﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//Чтобы проиграть звук в обьекта к которому относится звук дописываем FindObjectOfType<AudioManager>().Play("Название звука из массива");
public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
   

    // Start is called before the first frame update
    void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.source=gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

    }

    // Update is called once per frame
    public void Play (string name)
    {
       Sound s= Array.Find(sounds, sound => sound.name == name);
        s.source.Play();

    }

    
}
