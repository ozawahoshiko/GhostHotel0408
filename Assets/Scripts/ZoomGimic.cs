using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ZoomGimic : MonoBehaviour
{
    [SerializeField] Item item;
    public Fungus.Flowchart flowchart = null;
    public bool endTalkFlag;

    //�ǂ��ł����s
    public static ZoomGimic instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    //�Y�[����̂��̂ɂ��Ă���A�Y�[���O�A�C�e�����N���b�N�����Ƃ�
    public void DisplayItem()
    {
        ZoomItems.instance.ShowAllZoom();
        gameObject.SetActive(true);
        BlockBG.instance.ShowBlock();
        //�N���b�N���ꂽ��_�C�A���O���Ă�
        CallDialog();
    }



    public Item SetZoomItem()
    {
        return item;
    }

    public void CallDialog()
    {

        if (item != null) {

            flowchart.SetIntegerVariable("room", (int)item.name);
            flowchart.SendFungusMessage("roomzoom");
            endTalkFlag = false;
        }

        endTalkFlag = false;
    }
    //#2�Œǉ�(�f�X�N�̌�) �J����ZOOMITEM��\��
    public void DisplayOpenItem()
    {
        if (DialLocker2.instance.CheckOpen())
        {
            ZoomItems.instance.ShowAllZoom();
            gameObject.SetActive(true);
            BlockBG.instance.ShowBlock();

            //�N���b�N���ꂽ��_�C�A���O���Ă�
            //CallDialog2();
        }

    }
    public void DisplayRockItem()
    {
        if (DialLocker2.instance.CheckOpen())
        {

        }
        else
        {
            ZoomItems.instance.ShowAllZoom();
            gameObject.SetActive(true);
            BlockBG.instance.ShowBlock();
            //�N���b�N���ꂽ��_�C�A���O���Ă�
            // CallDialog2();
        }

    }
    //#2�Œǉ�(�i�{�[���̌�) �J����ZOOMITEM��\��
    public void DisplayOpenItem3()
    {
        if (DialLocker3.instance.CheckOpen())
        {
            ZoomItems.instance.ShowAllZoom();
            gameObject.SetActive(true);
            BlockBG.instance.ShowBlock();

        }

    }
    public void DisplayRockItem3()
    {
        if (DialLocker3.instance.CheckOpen())
        {

        }
        else
        {
            ZoomItems.instance.ShowAllZoom();
            gameObject.SetActive(true);
            BlockBG.instance.ShowBlock();

        }
    }



        //#3�Œǉ�(�M�̒I��) �J����ZOOMITEM��\��
        public void DisplayOpenItem4()
        {
            if (DialLocker03.instance.CheckOpen())
            {
                ZoomItems.instance.ShowAllZoom();
                gameObject.SetActive(true);
                BlockBG.instance.ShowBlock();

            }

        }
        public void DisplayRockItem4()
        {
            if (DialLocker03.instance.CheckOpen())
            {

            }
            else
            {
                ZoomItems.instance.ShowAllZoom();
                gameObject.SetActive(true);
                BlockBG.instance.ShowBlock();

            }

        }
    public void DisplayOpenItem5()
    {
        if (DialLocker032.instance.CheckOpen())
        {
            ZoomItems.instance.ShowAllZoom();
            gameObject.SetActive(true);
            BlockBG.instance.ShowBlock();

        }

    }
    public void DisplayRockItem5()
    {
        if (DialLocker032.instance.CheckOpen())
        {

        }
        else
        {
            ZoomItems.instance.ShowAllZoom();
            gameObject.SetActive(true);
            BlockBG.instance.ShowBlock();

        }

    }
    //#4�Œǉ�(�h���L���������̂���) �J����ZOOMITEM��\��
    public void DisplayOpenItem6()
    {
        if (DialLocker04.instance.CheckOpen())
        {
            ZoomItems.instance.ShowAllZoom();
            gameObject.SetActive(true);
            BlockBG.instance.ShowBlock();

        }

    }
    public void DisplayRockItem6()
    {
        if (DialLocker04.instance.CheckOpen())
        {

        }
        else
        {
            ZoomItems.instance.ShowAllZoom();
            gameObject.SetActive(true);
            BlockBG.instance.ShowBlock();

        }

    }
} 
