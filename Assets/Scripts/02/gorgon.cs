using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class gorgon : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    // Start is called before the first frame update
    public void Onclick()
    {
        flowchart.SendFungusMessage("gorgon");
    }
}
