using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foodSpeces : MonoBehaviour
{
    [SerializeField] public Food food=default;

    //�N���b�N���ꂽ��
    public void OnClickObj()
    {
        //����t���Ƀt�[�h�n���A�X�v�[���Ƀt�[�h�n��
        moritukedai.instance.GetFood(food);
        
        Spoon.instance.GetSpoonFood(food);
    }
}
