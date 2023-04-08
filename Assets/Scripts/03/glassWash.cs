using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class glassWash : MonoBehaviour
{
    [SerializeField] Item.Name clearItem;
    [SerializeField] Item showItem;

    public Fungus.Flowchart flowchart = null;
    Item useditem;
    public void GlassWash()
    {
        
            bool clear = ItemBox13.instance.TryUseItem(clearItem);
            //もしスロット画像にclearItem（汚れたコップ）がはいっていれば
            if (clear == true)
            {
                CallClean();
             
                flowchart.SendFungusMessage("clean");

            }
    }
    
    //掃除できた時、zoomアイテムを出す
    public void CallClean()
    {
        HideUsedItem.instance.HideUsedItems(27);
        ZoomItem.instance.ShowZoomImage(showItem);

        ItemBox13.instance.JustSetSlot(showItem);
        

    }
   
}
