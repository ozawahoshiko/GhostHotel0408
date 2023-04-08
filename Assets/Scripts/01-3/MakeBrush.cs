using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class MakeBrush : MonoBehaviour
{  
    //�ǂ��ł����s
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

    //��炪�o�Ă���Ƃ��A�؂̖_���^�b�v������������ĐV�����摜���o��
    public void Makebrush()
    {

        item = ZoomItem.instance.CheckZoomItem();
        //�^�b�v����Zoom�A�C�e����clearItem2(���j�̎�
        if (item.name == clearItem2)
        {
            bool clear = ItemBox13.instance.TryUseItem(clearItem1);
            //�����X���b�g�摜��clearItem1(�؂̖_)���͂����Ă����
            if (clear == true)
            {
                //�u���V�̕������ĂԁA�t���O������
                flowchart.SetBooleanVariable("brushflag", true);
                flowchart.SendFungusMessage("brush");
                //flowchart.SetIntegerVariable("itemnum", 7);
                //ZoomItem.instance.ShowZoomImage(replaceItem);

                //�^�b�v�����̂��؂̖_�̎�
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

        //�u���V���ł������Azoom�A�C�e�����o��
        
        
    }
    Item useditem;
    //�{�b�N�X�m�F���Ė؂̖_�Ƃ�炪�����Ă������
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
