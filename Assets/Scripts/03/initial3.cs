using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initial3 : MonoBehaviour
{
    public GameObject
         handazoom,   posterzoom,
         fireplacezoomb,  coffinb, 
         mirrorzoom, coffinzoom, dqnumzoom, 
        turnlistzoom,drawzooma, drawzoomb, cardboardzooma,dartzoom,
        plateset, cardboardzoomb,
        wolfsittingtalk1,shelfzooma, shelfzoomb, shelfnumzoom,
       wolfsittingtalk2, water, moritukedai,memozoom,
     cupbzooma, cupbzoomb, cupbnumzoom,
        box;

    [SerializeField] Item bento1, bento2, bento3;


    void HideRobbyObject()
    {
        box.SetActive(false);
        handazoom.SetActive(false);
       
        posterzoom.SetActive(false);
        fireplacezoomb.SetActive(false);
        coffinb.SetActive(true);
        mirrorzoom.SetActive(false);
        coffinzoom.SetActive(false);
        dqnumzoom.SetActive(false);

        turnlistzoom.SetActive(false);
        drawzooma.SetActive(false);
   
        dartzoom.SetActive(false);
        drawzooma.SetActive(false);
        drawzoomb.SetActive(false);        
        plateset.SetActive(false);
        //plateonwall.SetActive(false);

        cardboardzooma.SetActive(false);
        cardboardzoomb.SetActive(false);
     
        wolfsittingtalk1.SetActive(false);
        wolfsittingtalk2.SetActive(false);
        shelfzooma.SetActive(false);
        shelfzoomb.SetActive(false);
        shelfnumzoom.SetActive(false);
        

        water.SetActive(false);
        memozoom.SetActive(false);
        moritukedai.SetActive(false);
       
        cupbzooma.SetActive(false);
        cupbzoomb.SetActive(false);
        cupbnumzoom.SetActive(false);
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
