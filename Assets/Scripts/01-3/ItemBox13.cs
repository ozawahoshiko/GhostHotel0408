using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
//�ςɂ��
public class ItemBox13 : MonoBehaviour
{
    //fungus
    public Fungus.Flowchart flowchart = null;
    //public string message = "";

    [SerializeField] Slot[] slots;
    //�ǉ�
    [SerializeField] ZoomItem zoomItem;
    [SerializeField]Slot selectedSlot =null ;
    public GameObject itemImage;
    bool endTalkFlag = false;
    //�ǂ��ł����s
    public static ItemBox13 instance;
 
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
            //�󂫂�����΃A�C�e�������
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
            //Debug.Log("�I��" + position);
            //Debug.Log("�i���o�[" + positionnum);

            if (endTalkFlag){
                selectedSlot = slots[position];
                zoomItem.SetZoomItem(selectedSlot.GetItem());
                slots[position].turnOn();
                //flowchart.SetIntegerVariable("itemnum", (int)selectedSlot.GetItem().name);
                endTalkFlag = false;
                flowchart.SetIntegerVariable("itemnum", (int)selectedSlot.GetItem().name);
                flowchart.SendFungusMessage("inbox");
                endTalkFlag = false;
                BlockBG.instance.ShowBlock();
                positionnum = -1;
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

            //slot����󂯎����item�̖��O���N���A�A�C�e���Ɠ����Ƃ��A
        }
        if (selectedSlot.GetItem() !=null) {
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
        else
        {
            return false;
        }
        
    }

    public void ForInitialItem()
    {
        positionnum = 0;
    }

    //�X���b�g�ɂ݂̂����
 
    public void JustSetSlot(Item item)
    {
        

        //���ׂẴN���b�N�\��������

        foreach (Slot slot in slots)
        {
            slot.HideTurnedOn();
        }

        foreach (Slot slot in slots)
        {

            if (slot.IsEmpty())
            {
                slot.SetItem(item);
                slot.turnOn();
                selectedSlot = slot;

                break;
            }
        }

    }
    bool isIteminBox = false;
    //�{�b�N�X�����ׂă`�F�b�N
    public bool CheckItemAllBox(Item.Name name)
    {
        foreach (Slot slot in slots)
        {
            if (slot.GetItem() != null)
            {
                if (slot.GetItem().name == name)
                {
                    isIteminBox = true;
                }
            }
            
        }
        return isIteminBox;
    }
    public void NullSelectSlot()
    {
        selectedSlot = null;
    }

}
