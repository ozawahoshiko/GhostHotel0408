using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fran7 : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    public void OnClick()
    {
        flowchart.SendFungusMessage("frantalk");
    }
}
