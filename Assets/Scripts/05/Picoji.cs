using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Picoji : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    [SerializeField] Item.Name bento;
    [SerializeField] Item medicine;
    [SerializeField] GameObject piczoom;

    bool picclearFlag = false;
    // Start is called before the first frame update
    public void PassBento()
    {
        bool clear = ItemBox13.instance.TryUseItem(bento);
        if (clear)
        {
            HideUsedItem.instance.HideUsedItems((int)bento);
            flowchart.SendFungusMessage("ojipassbento");
            picclearFlag = true;
        }
        else
        {
            if (picclearFlag)
            {

            }
            else
            {
                flowchart.SendFungusMessage("guti");
            }
        }
        //flowchart.SendFungusMessage("wolf");
    }

    public void PassMedcine()
    {
        
        ItemBox13.instance.SetItem(medicine);
    }
    public void CloseDialog()
    {

        piczoom.SetActive(false);
    }

    public void Showzoom()
    {

        piczoom.SetActive(true);
        flowchart.SendFungusMessage("closepic");
    }

    public void girl()
    {
        flowchart.SendFungusMessage("girl");
        piczoom.SetActive(true);
    }
    public void jiji()
    {
        flowchart.SendFungusMessage("jiji");
        piczoom.SetActive(true);
    }
}
