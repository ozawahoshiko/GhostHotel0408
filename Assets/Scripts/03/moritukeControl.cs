using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moritukeControl : MonoBehaviour
{
    [SerializeField]
    GameObject moritukedai, dish1, dish2, dish3;
    [SerializeField] Item bento1,bento2,bento3;
    public void GameStart()
    {
        moritukedai.SetActive(true);
        dish1.SetActive(true);
        dish2.SetActive(false);
        dish3.SetActive(false);
    }
    public void NextGame()
    {
        dish1.SetActive(false);
        dish2.SetActive(true);
        dish3.SetActive(false);
        ItemBox13.instance.JustSetSlot(bento1);
    }
    public void LastGame()
    {
        dish1.SetActive(false);
        dish2.SetActive(false);
        dish3.SetActive(true);
        ItemBox13.instance.JustSetSlot(bento2);
    }
    public void AllClear()
    {
        ItemBox13.instance.JustSetSlot(bento3);
        GameManage.instance.GoMenu();
    }
    }
