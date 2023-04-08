using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class ClosedDoor : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    public AudioClip closeddoor;
    AudioSource audioSource;
    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }
    public void Onclick()
    {
        audioSource.PlayOneShot(closeddoor);
        
    }
    
        
}
