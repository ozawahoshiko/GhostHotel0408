using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class rightPic2 : MonoBehaviour
{
    //爺の話しがおわったか
    bool ojiend = false;
    public Fungus.Flowchart flowchart = null;

    [SerializeField] GameObject piczoom;
    //クリックしたら
    public void Onclick()
    {
        if (ojiend)
        {
            //拡大
            piczoom.SetActive(true);
            flowchart.SendFungusMessage("closepic");

        }
        else
        {
            flowchart.SendFungusMessage("girltalk");
        }
       
        
    }

    
    public void SetojiEnd()
    {
        ojiend = true;
    }


}
