using Unity.Audio;
using UnityEngine;
using System;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public Slider volumeSlider;
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.pitch = s.pitch;
            s.source.volume = s.volume;
            s.source.loop = s.loop;

        }

        volumeSlider.value = volumeSlider.maxValue/3;
    }

   
    void Start()
    {
        Play("Theme");
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, x => x.name == name);
        if (s!=null)
        {
        s.source.Play();
        }
        else {
            Debug.LogWarning("Audio "+name+" not found");
            return;
        }
    }
}
