using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class rightPic : MonoBehaviour
{
    //��̘b�������������
    bool ojiend = false;
    public Fungus.Flowchart flowchart = null;

    [SerializeField] GameObject piczoom;
    //�N���b�N������
    public void Onclick()
    {
        if (ojiend)
        {
            //�g��
            piczoom.SetActive(true);
            flowchart.SendFungusMessage("closepic");

        }
        else
        {
            flowchart.SendFungusMessage("dogtalk");
        }
       
        
    }

    
    public void SetojiEnd()
    {
        ojiend = true;
    }


}
