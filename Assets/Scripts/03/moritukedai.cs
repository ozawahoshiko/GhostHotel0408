using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moritukedai : MonoBehaviour
{
    //[SerializeField] foodSpeces[] foods;
    public static moritukedai instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    Food nowSelectfood;
    //foodSpeces���N���b�N���ꂽ��Food��񂤂��Ƃ�A�t�[�h�Ԃ�

    public void GetFood(Food food)
    {
        nowSelectfood = food;
        
    }
    //���M�Ƀt�[�h�n��
    public Food SetFood()
    {
        return nowSelectfood;
    }
    /* int positionn=-1;
      public void OnclickFood(int position)
      {
          positionn = position;
          Debug.Log("food��" + positionn);
      }

      public int ReturnFoodPosition()
      {
          return positionn;
      }
     */



}
