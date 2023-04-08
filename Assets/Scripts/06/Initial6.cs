using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initial6 : MonoBehaviour
{

    public GameObject
         handazoom,  posterzoom,
         fireplacezoomb, coffinb,
         mirrorzoom, coffinzoom,
        turnlistzoom, drawzooma, drawzoomb, cardboardzooma, dartzoom,
        plateset, cardboardzoomb,
       shelfzooma, shelfzoomb,
       water,
     cupbzooma, cupbzoomb, fpzooma, fpzoomb,
         spearzooma, toyboxnumzoom,
         blockbg, box;

    [SerializeField] Item bento1;


    void HideRobbyObject()
    {

        box.SetActive(true);
        handazoom.SetActive(false);
      
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
       
       
        shelfzooma.SetActive(false);
        shelfzoomb.SetActive(false);


        water.SetActive(false);

        cupbzooma.SetActive(false);
        cupbzoomb.SetActive(false);


        fpzooma.SetActive(false);
        fpzoomb.SetActive(false);
        
        
        spearzooma.SetActive(false);
        toyboxnumzoom.SetActive(false);


    }


    // Start is called before the first frame update
    void Start()
    {
        HideRobbyObject();


        BlockBG.instance.ShowBlock();
        ItemBox13.instance.SetendTalkflag();
        ItemBox13.instance.JustSetSlot(bento1);


    }

    public void ShowItem()
    {

        //ItemBox13.instance.ForInitialItem();
        box.SetActive(true);
    }



    /*public void ShowW1()
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

    }*/
}
