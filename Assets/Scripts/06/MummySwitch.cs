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
        //ON�̂Ƃ������ꂽ��摜�w�i�ς���OFF�ɂ���
        if (switchstate)
        {
            BG.GetComponent<Image>().sprite = switchOFF;
            switchstate = false;
            spearzooma.GetComponent<Image>().sprite = spearzoomb;
        }//OFF�̂Ƃ��摜������ON�ɂ���
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
