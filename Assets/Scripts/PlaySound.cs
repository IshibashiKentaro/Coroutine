using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    AudioSource soundSE01;
    public GameObject player;
    Player playerScript;

    void Start()
    {
        soundSE01 = GetComponent<AudioSource>();
        playerScript = player.GetComponent<Player>();
    }
    void Update()
    {
        if (playerScript.getDestroy==true)
        {    
            soundSE01.PlayOneShot(soundSE01.clip);
        }
    }
}
