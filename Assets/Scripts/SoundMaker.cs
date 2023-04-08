using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMaker : MonoBehaviour
{
    [SerializeField] AudioClip sound;
    AudioSource audioSource;

    public static SoundMaker instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    //Œø‰Ê‰¹
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Sound()
    {
        audioSource.PlayOneShot(sound);
        //GameManage.instance.GoMenu();
    }
    // 3. ’âŽ~
    public void Stop()
    {
        audioSource.Stop();
    }
}
