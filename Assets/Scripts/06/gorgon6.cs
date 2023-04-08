using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class gorgon6 : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    [SerializeField] Item.Name doll;
    [SerializeField] Item dollStone;

    bool passedDoll = false;
    //Ç«Ç±Ç≈Ç‡é¿çs
    public static gorgon6 instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void OnclickGorgon()
    {
        bool clear = ItemBox13.instance.TryUseItem(doll);

        if (clear) { 
               flowchart.SendFungusMessage("gorgonpass");
            HideUsedItem.instance.HideUsedItems((int)doll);
            passedDoll = true;
        }
        else
        {
            flowchart.SendFungusMessage("gorgonnone");
        }

    }
    public void PassDoll()
    {
        ItemBox13.instance.SetItem(dollStone);
        BlockBG.instance.ShowBlock();
    }
    public bool CheckDoll()
    {
        return passedDoll;
    }
}
