using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statue : MonoBehaviour
{
    [SerializeField] Item.Name clearItem;
    //public GameObject itemImage;
    // 推された時、アイテムを持っていれば色を白にしてアイテムを消す
    public void Onclick()
    {
        bool clear = ItemBox13.instance.TryUseItem(clearItem);
        if (clear)
        {
            this.GetComponent<Image>().color = Color.white;
            HideUsedItem.instance.HideUsedItems((int)clearItem);

           
        }
    }

    //もしマッチを持った時に像がアイテム欄にあれば消してアイテム出す

    public void SetStatue()
    {
        if (ItemBox13.instance.CheckItemAllBox(clearItem))
        {
            this.GetComponent<Image>().color = Color.white;
            HideUsedItem.instance.HideUsedItems((int)clearItem);
        }
    }
    
}
