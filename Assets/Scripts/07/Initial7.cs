using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initial7 : MonoBehaviour
{
    public GameObject
         handazoom, posterzoom,
         fireplacezoomb, coffinb,
         mirrorzoom, coffinzoom,
        turnlistzoom, drawzooma, drawzoomb, cardboardzooma, dartzoom,
        plateset, cardboardzoomb,
       shelfzooma, shelfzoomb,
       water,
     cupbzooma, cupbzoomb, fpzooma, fpzoomb,
         spearzooma, picOjizoom, picOjinumzoom, picOjiopen,secretword,
        batszoom,
         blockbg, box;

  


    void HideRobbyObject()
    {

        box.SetActive(false);
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
        
        picOjizoom.SetActive(false);
        picOjinumzoom.SetActive(false);
        picOjiopen.SetActive(false);
        secretword.SetActive(false);
        batszoom.SetActive(false);
       
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
}
