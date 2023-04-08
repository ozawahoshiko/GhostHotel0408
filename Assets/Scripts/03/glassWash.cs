using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class glassWash : MonoBehaviour
{
    [SerializeField] Item.Name clearItem;
    [SerializeField] Item showItem;

    public Fungus.Flowchart flowchart = null;
    Item useditem;
    public void GlassWash()
    {
        
            bool clear = ItemBox13.instance.TryUseItem(clearItem);
            //�����X���b�g�摜��clearItem�i���ꂽ�R�b�v�j���͂����Ă����
            if (clear == true)
            {
                CallClean();
             
                flowchart.SendFungusMessage("clean");

            }
    }
    
    //�|���ł������Azoom�A�C�e�����o��
    public void CallClean()
    {
        HideUsedItem.instance.HideUsedItems(27);
        ZoomItem.instance.ShowZoomImage(showItem);

        ItemBox13.instance.JustSetSlot(showItem);
        

    }
   
}
