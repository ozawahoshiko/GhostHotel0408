using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
//�ςɂ��
public class ItemBox : MonoBehaviour
{
    //fungus
    public Fungus.Flowchart flowchart = null;
    //public string message = "";

    [SerializeField] Slot[] slots;
    //�ǉ�
    [SerializeField] ZoomItem zoomItem;
    [SerializeField]Slot selectedSlot =null ;
    public GameObject itemImage;
    //Item item;
    bool endTalkFlag = false;
    //�ǂ��ł����s
    public static ItemBox instance;
    
 
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            //�q�v�f�̒���Slot�v�f�̂�W�߂Ă���
            slots = GetComponentsInChildren<Slot>();

        }
    }

   

    //PickOBJ���N���b�N���ꂽ��X���b�g�ɂ������������
    public void SetItem(Item item)
    {
        endTalkFlag = false;
        //flowchart.SendFungusMessage("reset");
        zoomItem.SetZoomItem(item);

            flowchart.SetIntegerVariable("itemnum", (int)item.name);
            flowchart.SendFungusMessage("start");
        endTalkFlag = false;
        //���ׂẴN���b�N�\��������


        foreach (Slot slot in slots)
        {
            slot.HideTurnedOn();
        }

        foreach (Slot slot in slots)
        {
            //Debug.Log("slot�ԍ��F"+slot);
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
        //���ׂẴN���b�N�\��������
        foreach (Slot slot in slots)
        {           
            slot.HideTurnedOn();
        }
        selectedSlot = null;

        //�A���N���b�N�̍ہAzoom�摜���o��
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
            //�I�����ꂽ�X���b�g�̂݃N���b�N�\��
            if (slots[position].OnclickSlot())
            {
                slots[position].turnOn();
                selectedSlot = slots[position];
                positionnum = position;
                
            }
        }
        

    }

    //�A�C�e���̎g�p�g���C���g����Ƃ��g��
    public bool TryUseItem(Item.Name name)
    {
        
        //�I���X���b�g�����邩�ǂ���
        if (selectedSlot == null)
        {
            //�����I�����Ă��Ȃ�
              return false;
        }
        //slot����󂯎����item�̖��O���N���A�A�C�e���Ɠ����Ƃ��A
        if (selectedSlot.GetItem().name == name)
        {
              return true;
        }
        else
        {
            //���̃A�C�e�����p��
            return false;
        }
        
    }




}
