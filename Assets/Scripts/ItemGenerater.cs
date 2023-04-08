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
        //itemList‚Ì’†‚©‚çName‚Æˆê’v‚µ‚½‚ç“¯‚¶item ‚ğ¶¬‚µ‚Ä“n‚·
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
