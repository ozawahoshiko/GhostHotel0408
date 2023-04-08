using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class MirrorCombi : MonoBehaviour
{
    [SerializeField] Item.Name clearItem1, clearItem2;
    [SerializeField] Item replaceItem;
    Item item;
    public Fungus.Flowchart flowchart = null;
    [SerializeField] Slot[] slots;
    Item useditem;
    public void Mirrorcombi()
    {

        item = ZoomItem.instance.CheckZoomItem();
        //タップしたZoomアイテムがclearItem2(鏡）の時
        if (item.name == clearItem2)
        {
            bool clear = ItemBox13.instance.TryUseItem(clearItem1);
            //もしスロット画像がclearItem1(メモ)がはいっていれば
            if (clear == true)
            {
                //ブラシの文言を呼ぶ、フラグもつける
                flowchart.SetBooleanVariable("mirrorflag", true);
                flowchart.SendFungusMessage("mirror");
               

                //タップしたのが木の棒の時
            }
        }
        else if (item.name == clearItem1)
        {
            bool clear = ItemBox13.instance.TryUseItem(clearItem2);
            if (clear == true)
            {
                flowchart.SetBooleanVariable("mirrorflag", true);
                flowchart.SendFungusMessage("mirror");

            }


        }
    }

    public void ShowReplace()
    {
        HideUsedItems();
        ZoomItem.instance.ShowZoomImage(replaceItem);
        ItemBox13.instance.JustSetSlot(replaceItem);

        //ブラシができた時、zoomアイテムを出す


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
                if ((int)useditem.name == 46 || (int)useditem.name == 47)
                {
                    slot.SetItem(null);
                    slot.ColorChange();
                }
            }

        }

    }
}
