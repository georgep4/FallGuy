﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ClickSound : MonoBehaviour
{

    public AudioClip sound;

    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ClickSound");

        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;
        //Any other setting you want to initialize

        button.onClick.AddListener(() => PlaySound());
    }

    // Update is called once per frame
    void PlaySound()
    {
        source.PlayOneShot(sound);
    }
}