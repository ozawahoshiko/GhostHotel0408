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
    //foodSpecesがクリックされたらFood情報うけとる、フード返す

    public void GetFood(Food food)
    {
        nowSelectfood = food;
        
    }
    //お皿にフード渡す
    public Food SetFood()
    {
        return nowSelectfood;
    }
    /* int positionn=-1;
      public void OnclickFood(int position)
      {
          positionn = position;
          Debug.Log("foodは" + positionn);
      }

      public int ReturnFoodPosition()
      {
          return positionn;
      }
     */



}
