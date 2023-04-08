using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Bord : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    public void OnClickObj()
    {
        flowchart.SetBooleanVariable("unlockflag", true);
        GameObject.Find("picOjopen").SetActive(false);
    }
}
