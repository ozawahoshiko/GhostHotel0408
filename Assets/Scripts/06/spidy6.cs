using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spidy6 : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;

    

    public void Onclick()
    {
        if (gorgon6.instance.CheckDoll())
        {
            flowchart.SendFungusMessage("spidypassedtalk");
        }
        else
        {
            flowchart.SendFungusMessage("spidytalk");
        }
           
    }
}
