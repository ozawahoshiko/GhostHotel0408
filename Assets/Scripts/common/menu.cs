using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public void Start()
    {
        menupanel.SetActive(false);
    }

    [SerializeField] GameObject menupanel;
    public void Close(){
        menupanel.SetActive(false);
    }
    public void Open()
    {
        menupanel.SetActive(true);
    }
    public void GoStageSelect()
    {
        GameManage.instance.GoStageSelect();
    }
}
