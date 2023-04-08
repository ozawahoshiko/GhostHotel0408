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
        //�^�b�v����Zoom�A�C�e����clearItem2(�{�[�h�j�̎�
        if (item.name == bord)
        {
            bool clear = ItemBox13.instance.TryUseItem(sheet);
            //�����X���b�g�摜��clearItem1(�V�[�g�@���͂����Ă����
            if (clear == true)
            {
                
                //�u���V�̕������ĂԁA�t���O������
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
