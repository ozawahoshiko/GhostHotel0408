using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class picoji7 : MonoBehaviour
{
    int stagecounter = 0;
    [SerializeField] Sprite picoji1, picoji2;
    [SerializeField] GameObject picoji, picojinum, picojopen;
    public Fungus.Flowchart flowchart = null;

    //0:おじさんの状態　1:おじさん傾き　2:ロック　3:開ける
    public void OnclickOji()
    {
        if (Diallocker7.instance.CheckOpen())
        {

            if (stagecounter == 0)
            {
                picoji.GetComponent<Image>().sprite = picoji2;
                stagecounter++;


                flowchart.SetIntegerVariable("room", 55);
                flowchart.SendFungusMessage("roomzoom");

            }
            else if (stagecounter == 1)
            {

                picoji.SetActive(false);
                picojopen.SetActive(true);
                stagecounter = 0;

                picoji.GetComponent<Image>().sprite = picoji1;
            }
        }
        else
        {
            if (stagecounter == 0)
            {
                picoji.GetComponent<Image>().sprite = picoji2;
                stagecounter++;


                flowchart.SetIntegerVariable("room", 55);
                flowchart.SendFungusMessage("roomzoom");

            }
            else if (stagecounter == 1)
            {

                picoji.SetActive(false);
                picojinum.SetActive(true);
                stagecounter = 0;

                picoji.GetComponent<Image>().sprite = picoji1;
            }
        }
        
        

    }

}
