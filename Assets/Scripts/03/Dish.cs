using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish : MonoBehaviour
{
    [SerializeField] DishSpace[] spaces;
    Food food0, food1, food2, food3, food4;

    public static Dish instance;
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
    public�@void GetFood()
    {
        
        food0 = spaces[0].CheckSpace();
        food1 = spaces[1].CheckSpace();
        food2 = spaces[2].CheckSpace();
        food3 = spaces[3].CheckSpace();
        food4 = spaces[4].CheckSpace();
    }


    //���i�����ƃ`�F�b�N
    public bool CheckFoods(int f1,int f2,int f3, int f4, int f5)
    {
        GetFood();
       
        //Debug.Log("a"+ (int)food0.type + "b" + (int)food1.type + "c" + (int)food2.type + "d" + (int)food3.type + "e" + (int)food4.type);
        if (food0!=null&& food1 != null && food2 != null)
        {
            if (f1 == (int)food0.type && f2 == (int)food1.type &&
                f3 == (int)food2.type && f4 == (int)food3.type && f5 == (int)food4.type)
            {
                return true;
            }
            return false;
        }
        return false;

    }

}
