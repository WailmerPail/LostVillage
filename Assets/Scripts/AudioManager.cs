
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class AudioManager : MonoBehaviour {
 
    private static AudioManager _instance;
    public static AudioManager Instance {
        get {
            return _instance;
        }
    }
 
    private AudioSource audioSource;
 
    private void Awake()
    {
        print("awake");
        _instance = this;
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }
 
    public void PlayAudio(AudioClip ac) {
        AudioSource.PlayClipAtPoint(ac, Camera.main.transform.position);
    }
 
    public void PlayAudioByName(string name) {
        AudioClip ac = Resources.Load<AudioClip>("Sounds/" + name);
        PlayAudio(ac);
    }
 
    public void PlayMusic(AudioClip ac)
    {
        if (audioSource.isPlaying) {
            audioSource.Stop();
        }
        this.audioSource.clip = ac;
        audioSource.Play();
    }
 
    public void PlayMusicByName(string name)
    {
        AudioClip ac = Resources.Load<AudioClip>("Sounds/" + name);
        PlayMusic(ac);
    }

    public void testInstance() {
        print("success!");
    }
}