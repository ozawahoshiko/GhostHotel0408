using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initial4 : MonoBehaviour
{
    public GameObject
         handazoom, handbzoom, posterzoom,
         fireplacezoomb,  coffinb, 
         mirrorzoom, coffinzoom, 
        turnlistzoom,drawzooma, drawzoomb, cardboardzooma,dartzoom,
        plateset, cardboardzoomb,
        wolfsittingtalk1,shelfzooma, shelfzoomb, 
       wolfsittingtalk2, water, memozoom,
     cupbzooma, cupbzoomb, cupbnumzoom, fpzooma,fpzoomb,fpnumzoom,
        box;

    [SerializeField] Item bento1, bento2, bento3;


    void HideRobbyObject()
    {
        box.SetActive(false);
        handazoom.SetActive(false);
        handbzoom.SetActive(false);
        posterzoom.SetActive(false);
        fireplacezoomb.SetActive(false);
        coffinb.SetActive(true);
        mirrorzoom.SetActive(false);
        coffinzoom.SetActive(false);
        

        turnlistzoom.SetActive(false);
        drawzooma.SetActive(false);
   
        dartzoom.SetActive(false);
        drawzooma.SetActive(false);
        drawzoomb.SetActive(false);        
        plateset.SetActive(true);
        //plateonwall.SetActive(false);

        cardboardzooma.SetActive(false);
        cardboardzoomb.SetActive(false);
     
        wolfsittingtalk1.SetActive(false);
        wolfsittingtalk2.SetActive(false);
        shelfzooma.SetActive(false);
        shelfzoomb.SetActive(false);
              

        water.SetActive(false);
        memozoom.SetActive(false);
      
       
        cupbzooma.SetActive(false);
        cupbzoomb.SetActive(false);
        cupbnumzoom.SetActive(false);

        fpzooma.SetActive(false);
        fpzoomb.SetActive(false);
        fpnumzoom.SetActive(false);

    }


    // Start is called before the first frame update
    void Start()
    {
        HideRobbyObject();
        
    
        BlockBG.instance.ShowBlock();
        ItemBox13.instance.JustSetSlot(bento1);
        ItemBox13.instance.JustSetSlot(bento2);
        ItemBox13.instance.JustSetSlot(bento3);
        ItemBox13.instance.NullSelectSlot();
    }

    public void ShowItem()
    {
        
        //ItemBox13.instance.ForInitialItem();
        box.SetActive(true);
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
