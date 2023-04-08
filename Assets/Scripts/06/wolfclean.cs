using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;


public class wolfclean : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    [SerializeField] Item toybox;
    [SerializeField] Sprite wolfnomal, wolfTalk;

    bool wolftalk = false;
    public void TalkStart()
    {
        if (wolftalk)
        {
            flowchart.SendFungusMessage("wolfclean2");
        }
        else
        {
            flowchart.SendFungusMessage("wolfclean1");
            wolftalk = true;
        }
        
    }

    public void PassBox()
    {
        ItemBox13.instance.SetItem(toybox);
        BlockBG.instance.ShowBlock();
    }

    public void woTalkSt()
    {
        this.GetComponent<Image>().sprite = wolfnomal;

    }
    public void woTalkEnd()
    {
        this.GetComponent<Image>().sprite = wolfTalk;
    }
}
