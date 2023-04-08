using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SheetonBord : MonoBehaviour
{

    [SerializeField] Item.Name bord, sheet;
    [SerializeField] Item replaceItem;
    Item item;
    [SerializeField] Slot[] slots;
    Item useditem;

    public Fungus.Flowchart flowchart = null;
    public void Sheetonbord()
    {

        item = ZoomItem.instance.CheckZoomItem();
        //タップしたZoomアイテムがclearItem2(ボード）の時
        if (item.name == bord)
        {
            bool clear = ItemBox13.instance.TryUseItem(sheet);
            //もしスロット画像がclearItem1(シート　がはいっていれば
            if (clear == true)
            {
                
                //ブラシの文言を呼ぶ、フラグもつける
                flowchart.SetBooleanVariable("sheetflag", true);
                flowchart.SendFungusMessage("sheet");      
            }
        }

    }
    public void ShowReplace()
    {
        HideUsedItems();
        ZoomItem.instance.ShowZoomImage(replaceItem);
        ItemBox13.instance.JustSetSlot(replaceItem);


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
                if ((int)useditem.name == 56 || (int)useditem.name == 58)
                {
                    slot.SetItem(null);
                    slot.ColorChange();
                }
            }

        }

    }
}
