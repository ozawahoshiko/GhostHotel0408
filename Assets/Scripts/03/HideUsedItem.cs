using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUsedItem : MonoBehaviour
{
    [SerializeField] Slot[] slots;
    Item useditem;
    //どこでも実行
    public static HideUsedItem instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    //スロットの中のアイテムを消す
    public void HideUsedItems(int num)
    {
        foreach (Slot slot in slots)
        {
            //Debug.Log(fordebug);
            useditem = slot.GetItem();
            //fordebug++;
            if (useditem != null)
            {
                if ((int)useditem.name == num)
                {
                    slot.SetItem(null);
                    slot.ColorChange();
                }
            }

        }

    }
}
