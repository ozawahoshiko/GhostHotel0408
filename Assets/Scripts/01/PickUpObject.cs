using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class PickUpObject : MonoBehaviour
{
    //fungus
    //public Fungus.Flowchart flowchart = null;
    //public string message = "";

    /*public void MessageStart()
    {
        flowchart.SendFungusMessage(message);
    }*/


    [SerializeField] Item.Name itemName;
    // [SerializeField] Item item;
    Item item;
    private void Start()
    {
        //itemType‚É‰‚¶‚Äitem‚ğ¶¬‚·‚é
        item = ItemGenerater.instance.Spawn(itemName);
    }

    //ƒNƒŠƒbƒN‚µ‚½‚çÁ‚·
    public void OnClickObj()
    {
        ItemBox.instance.SetItem(item);
        //MessageStart();
        gameObject.SetActive(false);
    }
}
