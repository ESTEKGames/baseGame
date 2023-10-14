using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audio;
   
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(audio);
    }
}
