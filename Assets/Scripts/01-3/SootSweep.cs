using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SootSweep : MonoBehaviour
{

    [SerializeField] Item.Name clearItem;
   // [SerializeField] Item.Name clearItem2;

    [SerializeField] GameObject replaceItem;
    Item item;
    public Fungus.Flowchart flowchart = null;
    [SerializeField] Slot[] slots;

   
    public void Sootsweep()
    {

        //item = ZoomItem.instance.CheckZoomItem();
        //クリックした時
       // if (item.name == clearItem2)
       // {
            bool clear = ItemBox13.instance.TryUseItem(clearItem);
            //もしスロット画像がclearItem1(ほうき)がはいっていれば
            if (clear == true)
            {
                //ブラシの文言を呼ぶ、フラグもつける
                flowchart.SetBooleanVariable("sootflag", true);
                flowchart.SendFungusMessage("soot");

            }
        //}
  
    }
    //掃除できた時、zoomアイテムを出す
    public void Callsoot()
    {
        HideUsedItems();
        replaceItem.SetActive(true);
        
        Destroy(GameObject.Find("soot"));
    }
    Item useditem;
    public void HideUsedItems()
    {
        foreach (Slot slot in slots)
        {
            //Debug.Log(fordebug);
            useditem = slot.GetItem();
            //fordebug++;
            if (useditem != null)
            {
                if ((int)useditem.name == 7)
                {
                    slot.SetItem(null);
                    slot.ColorChange();
                }
            }

        }

    }
}
