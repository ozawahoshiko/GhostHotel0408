using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class handsAnime : MonoBehaviour
{
   
    

    private Animator anim;

    //どこでも実行
    public static handsAnime　instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        //変数animに、Animatorコンポーネントを設定する
        anim = gameObject.GetComponent<Animator>();
    }

    
    //クリックしたとき
    public void StartHandAnime()
    {
        
      
                //アニメーション開始
       anim.SetBool("fire", true);

        }
        

        
       
        
    

}
