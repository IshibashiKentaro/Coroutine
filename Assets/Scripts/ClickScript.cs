using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ClickScript : MonoBehaviour
{
    private AudioSource button_AudioSource;

    void Start()
    {
        button_AudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    public void ButtonClick()
    {
        button_AudioSource.PlayOneShot(button_AudioSource.clip);
    }
}