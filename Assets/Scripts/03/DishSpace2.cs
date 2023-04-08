using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DishSpace2 : MonoBehaviour
{
    
    Image image = default;
    Food nowfood2;

    //コンストラクタ
   /* public DishSpace(int r)
    {
        this.r = r;
    }*/
    
    //お皿のスペース

    private void Awake()
    {
        image = GetComponent<Image>(); //imageにImageコンポーネントを入れる
    }
    //お皿からフード受け取って画像表示
    public void SetFood(Food food)
    {
        //intからEnumに変える
        //var FoodType =(Food)Enum.ToObject(typeof(Food), foodnum);
        //image.sprite = FoodType.sprite;
        //白くする

        if (food != null)
        {
            this.GetComponent<Image>().color = Color.white;
            image.sprite = food.sprite;
            nowfood2 = food;
            // Debug.Log("おさらにもったのだ"+nowfood.type);
            //DishSpace dishs = new DishSpace(2);
            //dishs.Test();

        }


    }
   



    public Food CheckSpace()
    {
        
        
        
        return nowfood2;
        
    }

}
