using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class dartshoot : MonoBehaviour
{
    [SerializeField] Item.Name clearItem;
    public Fungus.Flowchart flowchart = null;
    [SerializeField] Slot[] slots;
    Item useditem;
    Animator animator;
    //どこでも実行
    public static dartshoot instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
   
    public void Dartanima()
    {
        animator.SetBool("isMove", true);
    }
    bool dartflag = false;
    bool dartflag1 = false;
    bool dartflag2 = false;
    public void ShootDart()
    {
        //クリックした時
        bool clear = ItemBox13.instance.TryUseItem(clearItem);
        //もしスロット画像がclearItem(ダーツ)がはいっていれば
        if (clear == true)
        {
            HideUsedItems();

            dartflag = true;
            //Dartanima();
            Invoke("GetDartflag", 1);

            Invoke("GetDartflag2", 2);
           
            //ブラシの文言を呼ぶ、フラグもつける
            //flowchart.SetBooleanVariable("turnlist", true);
            //flowchart.SendFungusMessage("turnlist");

        }
    }
    public void GetDartflag()
    {
        dartflag1 = true;
    }
    public void GetDartflag2()
    {
        dartflag2 = true;
    }
    public bool SetDartFlag()
    {
        return dartflag;
    }
    public bool SetDartFlag1()
    {
        return dartflag1;
    }
    public bool SetDartFlag2()
    {
        return dartflag2;
    }
    //bool plateSeted = false;
    //掃除できた時、zoomアイテムを出す
    public void DartMove()
    {
        

        //showItem1.SetActive(true);
        //showItem2.SetActive(true);
        //showItem3.SetActive(true);
       // plateSeted = true;
    }
    public void HideUsedItems()
    {
        foreach (Slot slot in slots)
        {
            //Debug.Log(fordebug);
            useditem = slot.GetItem();
            //fordebug++;
            if (useditem != null)
            {
                if ((int)useditem.name == 22)
                {
                    slot.SetItem(null);
                    slot.ColorChange();
                }
            }

        }

    }
}
