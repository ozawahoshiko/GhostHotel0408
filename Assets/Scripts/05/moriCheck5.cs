using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class moriCheck5 : MonoBehaviour
{

    [SerializeField] string message;
    public Fungus.Flowchart flowchart = null;
    //クリア条件

    //完成ボタンをおされたとき
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
