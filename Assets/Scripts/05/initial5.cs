using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initial5 : MonoBehaviour
{
    public GameObject
         handazoom, handbzoom, posterzoom,
         fireplacezoomb,  coffinb, 
         mirrorzoom, coffinzoom, 
        turnlistzoom,drawzooma, drawzoomb, cardboardzooma,dartzoom,
        plateset, cardboardzoomb,
        wolfstand,wolfsitting,wolfsittingtalk1, wolfsittingtalk2, shelfzooma, shelfzoomb, 
       water,
     cupbzooma, cupbzoomb,  fpzooma,fpzoomb,
        piczoom,pic3,pic4, 
         moritukedai, blockbg,box,turnedOn0;

    [SerializeField] Item bento1;


    void HideRobbyObject()
    {
        
        box.SetActive(true);
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
        wolfstand.SetActive(false);
        wolfsitting.SetActive(false);
        wolfsittingtalk1.SetActive(false);
        wolfsittingtalk2.SetActive(false);
        shelfzooma.SetActive(false);
        shelfzoomb.SetActive(false);
       

        water.SetActive(false);
      
        cupbzooma.SetActive(false);
        cupbzoomb.SetActive(false);
       

        fpzooma.SetActive(false);
        fpzoomb.SetActive(false);
      
        piczoom.SetActive(false);
        pic3.SetActive(false) ;
        pic4.SetActive(false);
        moritukedai.SetActive(false);

    }


    // Start is called before the first frame update
    void Start()
    {
        HideRobbyObject();
        
    
       BlockBG.instance.HideBlock();
        ItemBox13.instance.SetendTalkflag();
       ItemBox13.instance.JustSetSlot(bento1);
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
