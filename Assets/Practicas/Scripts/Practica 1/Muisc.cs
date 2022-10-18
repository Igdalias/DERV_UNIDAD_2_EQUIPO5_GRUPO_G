using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muisc : MonoBehaviour
{

    [SerializeField]
    AudioSource audio;

  

    private void OnTriggerEnter(Collider other)
    {
        audio.Play();

        string name;
        string tag;

        name = other.gameObject.name;
        tag = other.gameObject.tag;

        Debug.Log("Trigger Enter - Nombre: " + name + " Tag: " + tag);
    }

    private void OnTriggerExit(Collider other)
    {
        audio.Stop();

        string name;
        string tag;

        name = other.gameObject.name;
        tag = other.gameObject.tag;

        Debug.Log("Trigger Exit - Nombre: " + name + " Tag: " + tag);
    }
}
