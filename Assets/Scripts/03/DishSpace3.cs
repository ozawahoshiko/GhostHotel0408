using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DishSpace3 : MonoBehaviour
{
    
    Image image = default;
    Food nowfood3;



    private void Awake()
    {
        image = GetComponent<Image>(); //image��Image�R���|�[�l���g������
    }
    //���M����t�[�h�󂯎���ĉ摜�\��
    public void SetFood(Food food)
    {
        //int����Enum�ɕς���
        //var FoodType =(Food)Enum.ToObject(typeof(Food), foodnum);
        //image.sprite = FoodType.sprite;
        //��������

        if (food != null)
        {
            this.GetComponent<Image>().color = Color.white;
            image.sprite = food.sprite;
            nowfood3 = food;
            // Debug.Log("������ɂ������̂�"+nowfood.type);
            //DishSpace dishs = new DishSpace(2);
            //dishs.Test();
        }



    }
   



    public Food CheckSpace()
    {
        
        
        return nowfood3;
        
    }

}
