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
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }
    public void Onclick()
    {
        audioSource.PlayOneShot(closeddoor);
        
    }
    
        
}
