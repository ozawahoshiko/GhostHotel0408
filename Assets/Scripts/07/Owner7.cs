using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Owner7 : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    [SerializeField] Sprite owntalk, ownnomal;

    public void Onclick()
    {
        flowchart.SendFungusMessage("ownertalk");
    }
    public void ownTalkSt()
    {
        this.GetComponent<Image>().sprite = owntalk;

    }
    public void ownTalkEnd()
    {
        this.GetComponent<Image>().sprite = ownnomal;
    }
}
