using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class handsAnime : MonoBehaviour
{
   
    

    private Animator anim;

    //�ǂ��ł����s
    public static handsAnime�@instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        //�ϐ�anim�ɁAAnimator�R���|�[�l���g��ݒ肷��
        anim = gameObject.GetComponent<Animator>();
    }

    
    //�N���b�N�����Ƃ�
    public void StartHandAnime()
    {
        
      
                //�A�j���[�V�����J�n
       anim.SetBool("fire", true);

        }
        

        
       
        
    

}
