using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnTrigger : MonoBehaviour
{
    public AudioClip mumTree;
    private AudioSource audioSource;

    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (audioSource && mumTree)
            {
                audioSource.PlayOneShot(mumTree);
            }
            else
            {
                Debug.LogWarning("Missing AudioSource" + gameObject.name);
            }
        }
    }
}