using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moritukeControl5 : MonoBehaviour
{
    [SerializeField]
    GameObject moritukedai, dish;
    [SerializeField] Item bdPlate, bdPlateb;
    // Start is called before the first frame update
    public void GameStart()
    {
        moritukedai.SetActive(true);
        dish.SetActive(true);
        ItemBox13.instance.JustSetSlot(bdPlate);
    }
    public void Restart()
    {
        moritukedai.SetActive(true);
        dish.SetActive(true);
    }

    public void Hidemorituke()
    {
        moritukedai.SetActive(false);
    }

    public void Clearmorituke()
    {
        moritukedai.SetActive(false);
        HideUsedItem.instance.HideUsedItems((int)bdPlate.name);
        ItemBox13.instance.JustSetSlot(bdPlateb);
    }


}
