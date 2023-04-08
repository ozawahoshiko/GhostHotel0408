using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initial2 : MonoBehaviour
{
    public GameObject
         handazoom, RockStaffroom,   posterzoom,
         fireplacezoomb,  coffinb, 
         mirrorzoom, coffinzoom, dqnumzoom, 
        turnlistzoom,drawzooma, drawzoomb, drawnumzoom, cardboardzooma,dartzoom,
        plateset,plateonwall, cardboardzoomb, cardboardnumzoom,
        wolfsittingtalk1,
       wolfsittingtalk2, box;
    public GameObject fran, owner;



    void HideRobbyObject()
    {
        handazoom.SetActive(false);
        RockStaffroom.SetActive(false);
        owner.SetActive(true);
        fran.SetActive(false);
        posterzoom.SetActive(false);
        fireplacezoomb.SetActive(false);
        coffinb.SetActive(true);
        mirrorzoom.SetActive(false);
        coffinzoom.SetActive(false);
        dqnumzoom.SetActive(false);

        turnlistzoom.SetActive(false);
        drawzooma.SetActive(false);
        drawnumzoom.SetActive(false);
        dartzoom.SetActive(false);
        drawzooma.SetActive(false);
        drawzoomb.SetActive(false);        
        plateset.SetActive(false);
        plateonwall.SetActive(false);

        cardboardzooma.SetActive(false);
        cardboardzoomb.SetActive(false);
        cardboardnumzoom.SetActive(false);
        wolfsittingtalk1.SetActive(false);
        wolfsittingtalk2.SetActive(false);
        box.SetActive(false);
        

    }


    // Start is called before the first frame update
    void Start()
    {
        HideRobbyObject();
        
    
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

    }
    public void CallHer()
    {
        fran.SetActive(true);

    }
    public void HideHer()
    {
        fran.SetActive(false);

    }

    public void ShowW1()
    {
        wolfsittingtalk1.SetActive(true);

    }

    public void ShowW2()
    {
        wolfsittingtalk2.SetActive(true);

    }

    public void HideW1()
    {
        wolfsittingtalk1.SetActive(false);

    }

    public void HideW2()
    {
        wolfsittingtalk2.SetActive(false);

    }

}
