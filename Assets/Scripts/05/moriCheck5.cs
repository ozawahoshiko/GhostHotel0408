using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class moriCheck5 : MonoBehaviour
{

    [SerializeField] string message;
    public Fungus.Flowchart flowchart = null;
    //�N���A����

    //�����{�^���������ꂽ�Ƃ�
   public void OnclickCheck1()
    {
        

        if (Dish5.instance.CheckFoods5(0, 0, 0, 0))       
        {

            flowchart.SendFungusMessage(message);
        }
        else
        {
            flowchart.SendFungusMessage("miss");

        }


    }

    
}
