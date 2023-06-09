using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerater : MonoBehaviour
{
    [SerializeField] ItemListEntity itemListEntity;
    public static ItemGenerater instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public Item Spawn(Item.Name name)
    {
        //itemListの中からNameと一致したら同じitem を生成して渡す
        foreach (Item item in itemListEntity.itemList)
        {
            if (item.name == name)
            {
                return new Item(item.name, item.sprite);

            }
        }
        return null;
    }
}
