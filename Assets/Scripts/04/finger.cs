using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finger : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        //変数animに、Animatorコンポーネントを設定する
        anim = gameObject.GetComponent<Animator>();
    }
    public void ThrowFinger2()
    {
        //アニメーション開始、指を吐き出す
        anim.SetBool("throw", true);
        transform.SetAsLastSibling();

    }
}


