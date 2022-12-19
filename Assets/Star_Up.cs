using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Up : MonoBehaviour
{

    [SerializeField] private AudioSource doorOpenAudioSource = null;

    private void OnTriggerEnter()
    {
        GameManager.instance.Win();
        doorOpenAudioSource.Play();
        Destroy(gameObject);
    }
}
