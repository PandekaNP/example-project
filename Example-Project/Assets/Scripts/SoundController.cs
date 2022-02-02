using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    private AudioSource SoundFx;
    [SerializeField] AudioClip clip1;
    [SerializeField] AudioClip clip2;
    [SerializeField] AudioClip clip3;
    [SerializeField] AudioClip clip4;
    [SerializeField] Button btnStop;
    [SerializeField] Button btnPlay1;
    [SerializeField] Button btnPlay2;
    [SerializeField] Button btnPlay3;
    [SerializeField] Button btnPlay4;

    void Awake()
    {
        SoundFx = GetComponent<AudioSource>();
        btnPlay1.onClick.AddListener(PlaySound1);
        btnPlay2.onClick.AddListener(PlaySound2);
        btnPlay3.onClick.AddListener(PlaySound3);
        btnPlay4.onClick.AddListener(PlaySound4);
        btnStop.onClick.AddListener(StopSound);
    }

    void PlaySound1()
    {
        SoundFx.clip = clip1;
        //SoundFx.loop = true;
        SoundFx.Play();
    }
    void PlaySound2()
    {
        SoundFx.clip = clip2;
        SoundFx.Play();
    }
    void PlaySound3()
    {
        SoundFx.clip = clip3;
        SoundFx.Play();
    }
    void PlaySound4()
    {
        SoundFx.clip = clip4;
        SoundFx.Play();
    }

    public void StopSound()
    {
        SoundFx.Stop();
        SoundFx.clip = null;
        SoundFx.loop = false;
    }

    void RotateCapsule()
    {
    }
}
