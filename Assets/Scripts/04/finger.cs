using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finger : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        //�ϐ�anim�ɁAAnimator�R���|�[�l���g��ݒ肷��
        anim = gameObject.GetComponent<Animator>();
    }
    public void ThrowFinger2()
    {
        //�A�j���[�V�����J�n�A�w��f���o��
        anim.SetBool("throw", true);
        transform.SetAsLastSibling();

    }
}


