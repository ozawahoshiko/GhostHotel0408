using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initial13 : MonoBehaviour
{
    public GameObject
         handazoom, RockStaffroom, owner, fran, posterzoom,
         fireplacezooma, fireplacezoomb, coffinb, straw,
         mirrorzoom, coffinzoom, dqnumzoom, coffina, nail,stick,box;
    [SerializeField] Item initialitem;


    void HideRobbyObject()
    {
        handazoom.SetActive(false);
        RockStaffroom.SetActive(false);
        owner.SetActive(false);
        fran.SetActive(false);
        posterzoom.SetActive(false);
        fireplacezooma.SetActive(false);
        fireplacezoomb.SetActive(false);
        coffinb.SetActive(false);
        straw.SetActive(false);
        mirrorzoom.SetActive(false);
        coffinzoom.SetActive(false);
        dqnumzoom.SetActive(false);
        nail.SetActive(true);
        stick.SetActive(false);
        box.SetActive(true);
        

    }


    // Start is called before the first frame update
    void Start()
    {
        HideRobbyObject();
        ItemBox13.instance.SetItem(initialitem);
        ItemBox13.instance.OnclickSlot(1);
        BlockBG.instance.ShowBlock();
      
    }

    public void ShowItem()
    {
        
        //ItemBox13.instance.ForInitialItem();
        box.SetActive(true);
    }
    public void CallHim()
    {
        owner.SetActive(true);
        ImageFader.instance.GetActive(true);

    }


}
