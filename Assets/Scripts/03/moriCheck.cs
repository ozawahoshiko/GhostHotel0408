using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class moriCheck : MonoBehaviour
{
    [SerializeField] string message;
    public Fungus.Flowchart flowchart = null;
    //クリア条件

    //完成ボタンをおされたとき
    public void OnclickCheck1()
    {//1043
        if (Dish.instance.CheckFoods(0,0,0,0,0))
        {
           
            flowchart.SendFungusMessage(message);
        }
        else
        {
            flowchart.SendFungusMessage("miss");
           
        }
        

    }
    //31124
    public void OnclickCheck2()
    {
        if (Dish2.instance.CheckFoods(1,1,1,1,1))
        {          
            flowchart.SendFungusMessage(message);
        }
        else
        {
            flowchart.SendFungusMessage("miss");
           
        }


    }
    //43112
    public void OnclickCheck3()
    {
        if (Dish3.instance.CheckFoods(0, 0, 0, 0, 0))
        {
 
            flowchart.SendFungusMessage(message);
        }
        else
        {
            flowchart.SendFungusMessage("miss");
       
        }


    }


}
