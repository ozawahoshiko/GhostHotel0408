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
        //ONのとき押されたら画像背景変えてOFFにする
        if (switchstate)
        {
            BG.GetComponent<Image>().sprite = switchOFF;
            switchstate = false;
            spearzooma.GetComponent<Image>().sprite = spearzoomb;
        }//OFFのとき画像かえてONにする
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
