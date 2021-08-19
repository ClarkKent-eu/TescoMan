using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSFX : MonoBehaviour
{
    public AudioSource playSource;

    void OnTriggerEnter(Collider other)
    {
        playSource.Play();
    }


}
