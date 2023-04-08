using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfControl : MonoBehaviour
{//どこでも実行
    public static wolfControl instance;
    GameObject[] zooms = new GameObject[22];
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    [SerializeField] GameObject wolfstand,wolfsit;
    bool wolfMessageSend = false;
//呼ばれて出てくる
    public void ShowStand()
    {
        wolfstand.SetActive(true);
    }

    public void SitDown()
    {
        wolfstand.SetActive(false);
        wolfsit.SetActive(true);
        wolfMessageSend = true;
    }
    //狼の伝達おわってるか
    public bool MessageCheck()
    {
        return wolfMessageSend;
    }

    public void SetFalse()
    {
        wolfMessageSend = false;
    }
}
