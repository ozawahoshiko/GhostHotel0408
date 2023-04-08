using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


public class Spidy5 : MonoBehaviour
{
    [SerializeField] Item birthDish;
    public Fungus.Flowchart flowchart = null;
    bool messageendflag = false;
    public void MessageEnd()
    {
        messageendflag = true;
    }

    public void talkspidy()
    {
        if (messageendflag)
        {
            flowchart.SendFungusMessage("spidyhint");
        }
        else
        {
            flowchart.SendFungusMessage("spidytalk");
        }
        
    }
}

