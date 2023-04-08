using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocked : MonoBehaviour
{
    public AudioClip unlock;
    AudioSource audioSource;
    //効果音
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    //ダイアログの後呼び出し
    public void Unlock()
    {
        audioSource.PlayOneShot(unlock);
        //GameManage.instance.GoMenu();
    }
}
