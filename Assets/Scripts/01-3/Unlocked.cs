using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocked : MonoBehaviour
{
    public AudioClip unlock;
    AudioSource audioSource;
    //���ʉ�
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    //�_�C�A���O�̌�Ăяo��
    public void Unlock()
    {
        audioSource.PlayOneShot(unlock);
        //GameManage.instance.GoMenu();
    }
}
