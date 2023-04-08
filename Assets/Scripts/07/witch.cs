using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class witch : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;

    bool firstcontact = false;

    public void Talkwitch()
    {
       

        if (firstcontact)
        {


            flowchart.SendFungusMessage("PWplease");
            //HideUsedItem.instance.HideUsedItems((int)bord);
        }
        else
        {
            flowchart.SendFungusMessage("witchtalk");
            firstcontact = true;
        }
    }
}
