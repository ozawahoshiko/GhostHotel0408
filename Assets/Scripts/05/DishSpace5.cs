using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DishSpace5 : MonoBehaviour
{
    Image image = default;
    Food nowfood5;
    // Start is called before the first frame update
    private void Awake()
    {
        image = GetComponent<Image>(); //imageにImageコンポーネントを入れる
    }
    //お皿からフード受け取って画像表示
    public void SetFood(Food food)
    {
        if (food != null)
        {
            this.GetComponent<Image>().color = Color.white;
            image.sprite = food.sprite;
            nowfood5 = food;
        }

        
        

    }
    public Food CheckSpace()
    {
 

        return nowfood5;

    }

 
}
