using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spoon : MonoBehaviour
{
    [SerializeField] SpoonFood[] sps;
    public static Spoon instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // フード名受け取って、spsを表示非表示コントロール
    public void GetSpoonFood(Food food)
    {
        Debug.Log(food.type);
        foreach(SpoonFood spoonfood in sps)
        {
            spoonfood.HideSp();
        }
       /* if ((int)food.type == 0)
        {
            sps[0].ShowSp();
        }*/
        for (int i = 0; i < 4; i++)
        {
            if ((int)food.type == i)
            {
                sps[i].ShowSp();
            }
        }
    }
}
