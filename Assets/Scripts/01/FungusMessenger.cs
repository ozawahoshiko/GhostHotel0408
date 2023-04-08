using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;




public class FungusMessenger : MonoBehaviour
{
    public static FungusMessenger instance;
    public string message = "";
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public Fungus.Flowchart flowchart = null;
    
    public void MessageStart()
    {
        flowchart.SendFungusMessage(message);
    }
}
