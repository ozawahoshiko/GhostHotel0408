using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class MummyDad : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    [SerializeField] Item.Name doll;

    public void PassStone()
    {
        bool clear = ItemBox13.instance.TryUseItem(doll);
        if (clear)
        {

            flowchart.SendFungusMessage("mummypass");
            HideUsedItem.instance.HideUsedItems((int)doll);
        }
        else
        {
            flowchart.SendFungusMessage("mummynnone");
        }
    }

    public void PassDish()
    {
        HideUsedItem.instance.HideUsedItems(33);
    }
}
