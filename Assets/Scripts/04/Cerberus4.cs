using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Cerberus4 : MonoBehaviour
{
    [SerializeField] Item.Name feed;
    [SerializeField] Sprite nomal,cerbthrow;
    public Fungus.Flowchart flowchart = null;

    //#4�Œǉ�
    bool fingerOff = false;
    public void ThrowFinger1()
    {
        bool clear = ItemBox13.instance.TryUseItem(feed);
        //�w���o����
        if (fingerOff)
        {
            //�������������
            if (clear)
            {
                //#4���т�����
                HideUsedItem.instance.HideUsedItems((int)feed);
                flowchart.SendFungusMessage("eat");
            }
            else
            {
                flowchart.SendFungusMessage("nofeed");
            }

        }
        else
        {
            fingerOff = true;
            //�w�f���o��
            flowchart.SendFungusMessage("finger");
            this.GetComponent<Image>().sprite = cerbthrow;
        }
       

    }
    //�H�ׂ�i�_�C�A���O����т����j
    public void Eat()
    {
        gameObject.SetActive(false);
        flowchart.SendFungusMessage("ending");
        //GameManage.instance.GoMenu();
    }

    public void CloseMouse()
    {
        this.GetComponent<Image>().sprite =nomal;
    }
}
