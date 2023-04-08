using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class MummyDad7 : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    //[SerializeField] Item.Name doll;

    public void TalkMummy()
    {

        flowchart.SendFungusMessage("talkmummy");
    }

    
}
