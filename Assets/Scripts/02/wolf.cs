using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class wolf : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    [SerializeField] Item.Name clearItem1, clearItem2, clearItem3;
    [SerializeField] Item statue;
    // Start is called before the first frame update
    //#2
    public void Onclick()
    {
        flowchart.SendFungusMessage("wolf");
    }

    bool passdflag=false;

//#4で追加
    public void PassBento()
    {
        //もしスロット画像にclearItem（弁当）がはいっていれば
        bool clear1 = ItemBox13.instance.TryUseItem(clearItem1);
        bool clear2 = ItemBox13.instance.TryUseItem(clearItem2);
        bool clear3 = ItemBox13.instance.TryUseItem(clearItem3);
        if (passdflag == false)
        {
            if (clear1)
            {
                passdflag = true;
                HideUsedItem.instance.HideUsedItems((int)clearItem1);
                
                flowchart.SendFungusMessage("passbento");
            }
            else if (clear2)
            {
                HideUsedItem.instance.HideUsedItems((int)clearItem2);
                passdflag = true;
                flowchart.SendFungusMessage("passbento");
            }
            else if (clear3)
            {
                HideUsedItem.instance.HideUsedItems((int)clearItem3);
                passdflag = true;
                flowchart.SendFungusMessage("passbento");
            }
            else
            {
              
                flowchart.SendFungusMessage("wh");
            }
        }
        else
        {
            flowchart.SendFungusMessage("passed");
        }
    }
    public void RecieveStatue()
    {
        ItemBox13.instance.JustSetSlot(statue);
    }

}

