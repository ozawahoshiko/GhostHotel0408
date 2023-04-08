using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
//ぱにょの
public class ItemBox : MonoBehaviour
{
    //fungus
    public Fungus.Flowchart flowchart = null;
    //public string message = "";

    [SerializeField] Slot[] slots;
    //追加
    [SerializeField] ZoomItem zoomItem;
    [SerializeField]Slot selectedSlot =null ;
    public GameObject itemImage;
    //Item item;
    bool endTalkFlag = false;
    //どこでも実行
    public static ItemBox instance;
    
 
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            //子要素の中でSlot要素のやつ集めてくる
            slots = GetComponentsInChildren<Slot>();

        }
    }

   

    //PickOBJがクリックされたらスロットにがぞうをいれる
    public void SetItem(Item item)
    {
        endTalkFlag = false;
        //flowchart.SendFungusMessage("reset");
        zoomItem.SetZoomItem(item);

            flowchart.SetIntegerVariable("itemnum", (int)item.name);
            flowchart.SendFungusMessage("start");
        endTalkFlag = false;
        //すべてのクリック表示を消す


        foreach (Slot slot in slots)
        {
            slot.HideTurnedOn();
        }

        foreach (Slot slot in slots)
        {
            //Debug.Log("slot番号："+slot);
            if (slot.IsEmpty())
            {
                slot.SetItem(item);
                slot.turnOn();
                selectedSlot = slot;
                break;
            }
        }

    }

    
    public void SetendTalkflag()
    {
        endTalkFlag = true;
    }
    public void SetStartTalkflag()
    {
        endTalkFlag = false;
    }



    int positionnum = -1;
   
    public void OnclickSlot(int position)
    {
        
        
        //flowchart.SendFungusMessage("reset");
        //すべてのクリック表示を消す
        foreach (Slot slot in slots)
        {           
            slot.HideTurnedOn();
        }
        selectedSlot = null;

        //連続クリックの際、zoom画像を出す
        if (positionnum == position)
        {
            if (endTalkFlag){
                selectedSlot = slots[position];
                zoomItem.SetZoomItem(selectedSlot.GetItem());
                slots[position].turnOn();
                //flowchart.SetIntegerVariable("itemnum", (int)selectedSlot.GetItem().name);
                endTalkFlag = false;
                flowchart.SetIntegerVariable("itemnum", (int)selectedSlot.GetItem().name);
                flowchart.SendFungusMessage("inbox");
                endTalkFlag = false;
            }
            

        }
        else {
            //選択されたスロットのみクリック表示
            if (slots[position].OnclickSlot())
            {
                slots[position].turnOn();
                selectedSlot = slots[position];
                positionnum = position;
                
            }
        }
        

    }

    //アイテムの使用トライ＆使えるとき使う
    public bool TryUseItem(Item.Name name)
    {
        
        //選択スロットがあるかどうか
        if (selectedSlot == null)
        {
            //何も選択していない
              return false;
        }
        //slotから受け取ったitemの名前がクリアアイテムと同じとき、
        if (selectedSlot.GetItem().name == name)
        {
              return true;
        }
        else
        {
            //他のアイテム利用時
            return false;
        }
        
    }




}
