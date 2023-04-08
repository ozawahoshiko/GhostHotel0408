using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class TurnList : MonoBehaviour
{
    [SerializeField] Item.Name clearItem;
    public Fungus.Flowchart flowchart = null;
    [SerializeField] GameObject showItem1;
    [SerializeField] GameObject showItem2;
    [SerializeField] GameObject showItem3;
    [SerializeField] Slot[] slots;
    Item useditem;
    // 表示している画像
    public Image dialogs;

    //画像のソース
    public Sprite[] markSources;
    //マークの種類＋MAX
    enum Mark
    {
        no0 = 0,
        no1 = 1,
        no2 = 2,
        no3 = 3,
        no4 = 4,
        no5 = 5,
        max = 6,
    }
    //鍵の数
    Mark currentMarks = Mark.no0;

    

    public void TurnListSet()
    {
        //クリックした時
        bool clear = ItemBox13.instance.TryUseItem(clearItem);
        //もしスロット画像がclearItem(円盤)がはいっていれば
        if (clear == true)
        {
            //ブラシの文言を呼ぶ、フラグもつける
            flowchart.SetBooleanVariable("turnlist", true);
            flowchart.SendFungusMessage("turnlist");

        }
    }
    bool plateSeted = false;
    //掃除できた時、zoomアイテムを出す
    public void Callplate()
    {
        HideUsedItems();
        showItem1.SetActive(true);
        showItem2.SetActive(true);
        showItem3.SetActive(true);
        plateSeted = true;
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
                if ((int)useditem.name == 23)
                {
                    slot.SetItem(null);
                    slot.ColorChange();
                }
            }

        }

    }

    //円盤がセットされた状態でクリックしたら
    public void OnclickPlate()
    {
        if (plateSeted)
        {
            ChangeMark();
            ShowMarkImage();
            //audioSource.PlayOneShot(click);
           
        }
    }
    //マーク変数を変更
    void ChangeMark()
    {
        currentMarks++;
        if (currentMarks >= Mark.max)
        {
            currentMarks = Mark.no0;
        }
    }
    //マーク変数に応じて画像表示
    void ShowMarkImage()
    {
        dialogs.sprite = GetSource(currentMarks);
    }
    Sprite GetSource(Mark mark)
    {
        int markIndex = (int)mark;
        return markSources[markIndex];
    }
    
}
