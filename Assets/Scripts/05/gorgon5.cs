using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class gorgon5 : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    [SerializeField] Item.Name medicine;
    [SerializeField] Sprite gorgonwake, gorgonfullwake;

    bool gorgonrecover = false;
    // Start is called before the first frame update
    public void Onclick()
    {
        bool clear = ItemBox13.instance.TryUseItem(medicine);

        if (clear)
        {
            
            this.GetComponent<Image>().sprite = gorgonwake;
            
            flowchart.SendFungusMessage("gorgonwake");
            gorgonrecover = true;

        }
        else
        {
            if (gorgonrecover)
            {
                flowchart.SendFungusMessage("gorgonrecover");
            }
            else
            {
                flowchart.SendFungusMessage("gorgon");
            }
               
        }
        
    }

    public void Cure()
    {
        HideUsedItem.instance.HideUsedItems((int)medicine);
        
    }

    public void Wake()
    {
        this.GetComponent<Image>().sprite = gorgonfullwake;
    }
}
