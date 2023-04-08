using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MummySwitch : MonoBehaviour
{
    [SerializeField] Sprite switchOn, switchOFF, spearzoomA, spearzoomb;
    [SerializeField] private GameObject spearzooma,BG;
    bool switchstate = true;

    public void Onclick()
    {
        //ON‚Ì‚Æ‚«‰Ÿ‚³‚ê‚½‚ç‰æ‘œ”wŒi•Ï‚¦‚ÄOFF‚É‚·‚é
        if (switchstate)
        {
            BG.GetComponent<Image>().sprite = switchOFF;
            switchstate = false;
            spearzooma.GetComponent<Image>().sprite = spearzoomb;
        }//OFF‚Ì‚Æ‚«‰æ‘œ‚©‚¦‚ÄON‚É‚·‚é
        else
        {
            BG.GetComponent<Image>().sprite = switchOn;
            switchstate = true;
            spearzooma.GetComponent<Image>().sprite = spearzoomA;
        }

    }
    public bool  CheckSwitch()
    {
        return switchstate;
    }
}
