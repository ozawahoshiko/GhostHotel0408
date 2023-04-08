using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Book : MonoBehaviour
{
    
    //[SerializeField] Item book;
    [SerializeField]Sprite bookopenwithsheet, bookclose, bookopen;
    [SerializeField] GameObject book;
    [SerializeField]Item sheet;
    Item item;
    bool bookopenstate = false;
    bool issheet = true;
   // int clickcount = 0;
    public Fungus.Flowchart flowchart = null;
    public void BookOpen()
    {  
        item = ZoomItem.instance.CheckZoomItem();             
        //タップしたZoomアイテムが本の時
        if ((int)item.name == 53)
        {//シートつきの時
            if (issheet)
            {
                if (bookopenstate !=true)
                {
                    book.GetComponent<Image>().sprite = bookopenwithsheet;
                    bookopenstate = true;
                  
                  
                } else {
                    //if (clickcount == 0)
                    //{
                        book.GetComponent<Image>().sprite = bookopen;
                        issheet = false;
                        flowchart.SetBooleanVariable("unlockflag3", true);
                    //flowchart.SetIntegerVariable("itemnum", 58);
                    ItemBox13.instance.SetItem(sheet);

                    bookopenstate = false;
                    

                }

            }//シートなしのとき
            else
            {
                //本が開いているとき
                if (bookopenstate)
                {                    
                        book.GetComponent<Image>().sprite = bookclose;                 
                        bookopenstate = false;
                   

                }//本が閉じているとき
                else
                {
                    book.GetComponent<Image>().sprite = bookopen;
                    bookopenstate = true;                  

                }
            }
           
        }

    }

    public void Resetflag()
    {
        bookopenstate = false;
    }


    public void FlowchartRestart()
    {
        flowchart.SendFungusMessage("start");
    }
}
