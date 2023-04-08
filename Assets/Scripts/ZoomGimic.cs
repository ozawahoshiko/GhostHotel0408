using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ZoomGimic : MonoBehaviour
{
    [SerializeField] Item item;
    public Fungus.Flowchart flowchart = null;
    public bool endTalkFlag;

    //どこでも実行
    public static ZoomGimic instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    //ズーム後のものにつけている、ズーム前アイテムをクリックしたとき
    public void DisplayItem()
    {
        ZoomItems.instance.ShowAllZoom();
        gameObject.SetActive(true);
        BlockBG.instance.ShowBlock();
        //クリックされたらダイアログも呼ぶ
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
    //#2で追加(デスクの鍵) 開いたZOOMITEMを表示
    public void DisplayOpenItem()
    {
        if (DialLocker2.instance.CheckOpen())
        {
            ZoomItems.instance.ShowAllZoom();
            gameObject.SetActive(true);
            BlockBG.instance.ShowBlock();

            //クリックされたらダイアログも呼ぶ
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
            //クリックされたらダイアログも呼ぶ
            // CallDialog2();
        }

    }
    //#2で追加(段ボールの鍵) 開いたZOOMITEMを表示
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



        //#3で追加(皿の棚鍵) 開いたZOOMITEMを表示
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
    //#4で追加(ドラキュラ部屋のかぎ) 開いたZOOMITEMを表示
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
