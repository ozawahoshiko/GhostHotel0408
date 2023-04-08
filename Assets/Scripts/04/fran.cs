using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class fran : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    [SerializeField] Item.Name clearItem1, clearItem2, clearItem3;
    bool passdflag1 = false;
    public void PassBento()
    {
       
        //もしスロット画像にclearItem（弁当）がはいっていれば
        bool clear1 = ItemBox13.instance.TryUseItem(clearItem1);
        bool clear2 = ItemBox13.instance.TryUseItem(clearItem2);
        bool clear3 = ItemBox13.instance.TryUseItem(clearItem3);
        if (passdflag1 == false)
        {
            if (clear1)
            {
                passdflag1 = true;
                HideUsedItem.instance.HideUsedItems((int)clearItem1);
                flowchart.SendFungusMessage("passbento1");
            }
            else if (clear2)
            {
                HideUsedItem.instance.HideUsedItems((int)clearItem2);
                passdflag1 = true;
                flowchart.SendFungusMessage("passbento1");
            }
            else if (clear3)
            {
                HideUsedItem.instance.HideUsedItems((int)clearItem3);
                passdflag1 = true;
                flowchart.SendFungusMessage("passbento1");
            }
            else
            {
              
                flowchart.SendFungusMessage("franfran");
            }
        }
        else
        {
            flowchart.SendFungusMessage("passedfran");
        }
    }
}
