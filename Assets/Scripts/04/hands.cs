using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hands : MonoBehaviour
{
    [SerializeField] Item.Name finger;
    [SerializeField] Item.Name match;

    [SerializeField] private GameObject hand;
    [SerializeField] private GameObject handbzoom;
    [SerializeField] private Sprite fullhand;
    


    bool fingerset = false;
    bool matchUsed = false;
    public void OnclickHand()
    {
        bool clear = ItemBox13.instance.TryUseItem(finger);
        bool clear2 = ItemBox13.instance.TryUseItem(match);

      //ゆびセット済みのとき
        if (fingerset)
        {
            //マッチ使い済みなら
            if (matchUsed)
            {
                //アニメーション開始
                handbzoom.SetActive(true);
                handsAnime.instance.StartHandAnime();
            }
            else
            {
                //マッチがあれば
                if (clear2)
                {
                    //アニメーション開始
                    handbzoom.SetActive(true);
                    handsAnime.instance.StartHandAnime();
                    //マッチ消す
                    HideUsedItem.instance.HideUsedItems((int)match);
                    matchUsed = true;
                }
            }
            

         }
        else
        {  //クリックしたとき、もしゆびを持っていれば、
           //ズーム画像に差し替える
           //おいてある指の画像差し替える差し替える、
           //使った指も消す
            if (clear)
            {
                hand.GetComponent<Image>().sprite = fullhand;
                this.GetComponent<Image>().sprite = handbzoom.GetComponent<Image>().sprite;
                HideUsedItem.instance.HideUsedItems((int)finger);
               
                fingerset = true;

            }
        }
        
        
    }

}
