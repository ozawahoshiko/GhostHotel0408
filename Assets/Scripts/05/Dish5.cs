using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish5 : MonoBehaviour
{
    [SerializeField] DishSpace5[] spaces;
    Food food0, food1, food2, food3;
    public static Dish5 instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    //���M�̃X�y�[�X�Ƀt�[�h�n��
    public void OnclickSpace(int position2)
    {

        spaces[position2].SetFood(PassFood());
    }

    //����t������t�[�h�󂯎���ēn��
    public Food PassFood()
    {
        return moritukedai.instance.SetFood();

        //foodPosition = moritukedai.instance.ReturnFoodPosition();

    }



    //�M�̓��e�󂯎��
    public void GetFood()
    {
        
        food0 = spaces[0].CheckSpace();
        food1 = spaces[1].CheckSpace();
        food2 = spaces[2].CheckSpace();
        food3 = spaces[3].CheckSpace();
        
    }


    //���i�����ƃ`�F�b�N
    public bool CheckFoods5(int f1, int f2, int f3, int f4)
    {
        
        GetFood();

        if (food0 != null && food1 != null && food2 != null)
        {
            if (f1 == (int)food0.type && f2 == (int)food1.type &&
                f3 == (int)food2.type && f4 == (int)food3.type)
            {
                return true;
            }
            return false;
        }
        return false;
        
        
    }
  

   

}
