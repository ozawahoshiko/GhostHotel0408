using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Gimmick013 : MonoBehaviour
{
    //追加
    [SerializeField] Item item;
    //Item item;

    [SerializeField] Item.Name clearItem;

    //fungus
    public Fungus.Flowchart flowchart = null;
    public string message = "";

    public void DisplayItem()
    {
        gameObject.SetActive(true);
        
    }
    public void HideItem()
    {
        gameObject.SetActive(false);
    }


    public void OnClickObj()
    {
        //アイテムもってるか
        bool clear =ItemBox13.instance.TryUseItem(clearItem);
        if(clear == true)
        {
            //アイテム使用効果　消す＆箱に入れる

            ItemBox13.instance.SetItem(item);
            gameObject.SetActive(false);
           
            
        }
        else
        {
            flowchart.SendFungusMessage(message);
           
        }
    }
  

  


}
