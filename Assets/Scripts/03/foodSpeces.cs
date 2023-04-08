using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foodSpeces : MonoBehaviour
{
    [SerializeField] public Food food=default;

    //クリックされたら
    public void OnClickObj()
    {
        //盛り付けにフード渡す、スプーンにフード渡す
        moritukedai.instance.GetFood(food);
        
        Spoon.instance.GetSpoonFood(food);
    }
}
