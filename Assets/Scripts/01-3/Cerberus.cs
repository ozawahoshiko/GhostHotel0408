using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Cerberus : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    public AudioClip baw;
    AudioSource audioSource;


    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();

    }
    public void Onclick()
    {
        audioSource.PlayOneShot(baw);
        flowchart.SendFungusMessage("talk");
    }

    
    

}
