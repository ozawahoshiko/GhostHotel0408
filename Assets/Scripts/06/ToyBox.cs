using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ToyBox : MonoBehaviour
{
    [SerializeField] Item.Name toybox;
    [SerializeField] GameObject toyboxnumzoom;
    [SerializeField] Item doll;
    [SerializeField] Item toyboxopen;
    public Fungus.Flowchart flowchart = null;
    public void OnclickZoomItem()
    {
        if(ZoomItem.instance.CheckZoomItem().name== toybox)
        {
            toyboxnumzoom.SetActive(true);
            ZoomItem.instance.HideItemBg();
        }
        if (ZoomItem.instance.CheckZoomItem().name == toyboxopen.name)
        {
     
            BlockBG.instance.ShowBlock();
            HideUsedItem.instance.HideUsedItems(49);
            //flowchart.SetBooleanVariable("unlockflag4", true);
            ItemBox13.instance.SetendTalkflag();
            ItemBox13.instance.SetItem(doll);
            flowchart.SetBooleanVariable("unlockflag5", true);
        }

    }
    public void OpenBox()
    {
        
        ItemBox13.instance.SetItem(toyboxopen);
        BlockBG.instance.ShowBlock();
        HideUsedItem.instance.HideUsedItems(48);
        
    }

   
    

}
