using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class spydy : MonoBehaviour
{
    [SerializeField] Item.Name clearItem;
    public Fungus.Flowchart flowchart = null;
    public void PassDish()
    {    
        bool clear = ItemBox13.instance.TryUseItem(clearItem);
        //�����X���b�g�摜��clearItem�i���M�j���͂����Ă����
        if (clear == true)
        {
          

            flowchart.SendFungusMessage("passdish");

        }
        else
        {
            flowchart.SendFungusMessage("spidy");
        }
    }
}
