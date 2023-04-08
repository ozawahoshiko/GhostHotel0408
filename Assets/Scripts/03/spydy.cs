using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class spydy : MonoBehaviour
{
    [SerializeField] Item.Name clearItem;
    public Fungus.Flowchart flowchart = null;
    public void PassDish()
    {    
        bool clear = ItemBox13.instance.TryUseItem(clearItem);
        //もしスロット画像にclearItem（お皿）がはいっていれば
        if (clear == true)
        {
          

            flowchart.SendFungusMessage("passdish");

        }
        else
        {
            flowchart.SendFungusMessage("spidy");
        }
    }
}
