using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class MakeBrush : MonoBehaviour
{  
    //どこでも実行
    public static MakeBrush instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    [SerializeField] Item.Name clearItem1;
    [SerializeField] Item.Name clearItem2;
    [SerializeField] Item replaceItem;
    Item item;
    public Fungus.Flowchart flowchart = null;
    [SerializeField] Slot[] slots;

    //わらが出ているとき、木の棒をタップしたらわら消して新しい画像を出す
    public void Makebrush()
    {

        item = ZoomItem.instance.CheckZoomItem();
        //タップしたZoomアイテムがclearItem2(わら）の時
        if (item.name == clearItem2)
        {
            bool clear = ItemBox13.instance.TryUseItem(clearItem1);
            //もしスロット画像がclearItem1(木の棒)がはいっていれば
            if (clear == true)
            {
                //ブラシの文言を呼ぶ、フラグもつける
                flowchart.SetBooleanVariable("brushflag", true);
                flowchart.SendFungusMessage("brush");
                //flowchart.SetIntegerVariable("itemnum", 7);
                //ZoomItem.instance.ShowZoomImage(replaceItem);

                //タップしたのが木の棒の時
            }
        }
        else if (item.name == clearItem1)
        {
            bool clear = ItemBox13.instance.TryUseItem(clearItem2);
            if (clear == true)
            {
                flowchart.SetBooleanVariable("brushflag", true);
                flowchart.SendFungusMessage("brush");

            }

        
        }
    }
    public void Callbrush()
    {
        HideUsedItems();
        ZoomItem.instance.ShowZoomImage(replaceItem);
      
        ItemBox13.instance.JustSetSlot(replaceItem);

        //ブラシができた時、zoomアイテムを出す
        
        
    }
    Item useditem;
    //ボックス確認して木の棒とわらが入ってたら消す
    public void HideUsedItems()
    {
        
        foreach (Slot slot in slots)
        {
            //Debug.Log(fordebug);
            useditem =slot.GetItem();
            //fordebug++;
            if (useditem != null)
            {
                if ((int)useditem.name == 1 || (int)useditem.name == 2)
                {
                    slot.SetItem(null);
                    slot.ColorChange();
                }       
            }
           
            
            

        }
        
    }
}
