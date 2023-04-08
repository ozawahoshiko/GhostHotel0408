using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openbyKey : MonoBehaviour
{
    [SerializeField] Item.Name key;
    [SerializeField] GameObject batszoom,batsnumzoom, hummeropen, b0,b1,b2,b3;
    [SerializeField] Sprite openbatszoom, hidehummer;

    public void Start()
    {
        b0.SetActive(false);
        b1.SetActive(false); 
        b2.SetActive(false);
        b3.SetActive(false);
    }
    public void OpenbyKey()
    {
        bool clear = ItemBox13.instance.TryUseItem(key);
        //�����X���b�g�摜��clearItem1(��)���͂����Ă����
        if (clear == true)
        {
            //�J�����啂̃Y�[���ɉ摜�����ւ�
            batsnumzoom.GetComponent<Image>().sprite = openbatszoom;
            b0.SetActive(true);
            b1.SetActive(true);
            b2.SetActive(true);
            b3.SetActive(true);
            HideUsedItem.instance.HideUsedItems(54);
        }
    }
    public void Showme()
    {
        if (dialLocker8.instance.CheckOpen())
        {
            hummeropen.SetActive(true);
        }
        else
        {
             batsnumzoom.SetActive(true);
        }
       
    }

    public void Hidehummer()
    {
        batszoom.GetComponent<Image>().sprite = hidehummer;
    }

}
