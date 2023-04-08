using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class PictureArrange : MonoBehaviour
{
   
    [SerializeField] private GameObject pic1;
    [SerializeField] private GameObject pic2;
    [SerializeField] private GameObject pic3;
    [SerializeField] private GameObject pic4;
    [SerializeField] Sprite picture1;
    [SerializeField] Sprite picture2;
    [SerializeField] Sprite picture3;
    [SerializeField] Sprite picture4;
    [SerializeField] private GameObject pic1onwall;
    [SerializeField] private GameObject pic2onwall;
    [SerializeField] private GameObject pic3onwall;
    [SerializeField] private GameObject pic4onwall;

 
    // Start is called before the first frame update

    //直前に何をクリックしたか
    bool count1 = false;
    
    bool count2 = false;
  
    bool count3 = false;
   
    bool count4 = false;

    bool ClearFlag = false;

    public Sprite karioki;
    public Fungus.Flowchart flowchart = null;

    public void counteroff()
    {
        count1 = false;
        count2 = false;
        count3 = false;
        count4 = false;
     
    }

    //クリア処理
    public void ClearCheck()
    {
        if (pic1.GetComponent<Image>().sprite==picture1&& pic2.GetComponent<Image>().sprite == picture2&&
            pic3.GetComponent<Image>().sprite == picture3&& pic4.GetComponent<Image>().sprite == picture4)
        {
           //背景の絵も変化
            pic1onwall.SetActive(false);
            pic2onwall.SetActive(false);
            pic3onwall.SetActive(true);
            pic4onwall.SetActive(true);
            //クリア後変更できないように
            ClearFlag = true;
            //ケーキのメモは消す
            HideUsedItem.instance.HideUsedItems(41);
            flowchart.SendFungusMessage("isClear");
        }       
        
    }


    public void pic1tap()
    {
        if (ClearFlag != true)
        {
            karioki = pic1.GetComponent<Image>().sprite;
            if (count2)
            {

                pic1.GetComponent<Image>().sprite = pic2.GetComponent<Image>().sprite;
                pic2.GetComponent<Image>().sprite = karioki;
                counteroff();
            }
            else if (count3)
            {

                pic1.GetComponent<Image>().sprite = pic3.GetComponent<Image>().sprite;
                pic3.GetComponent<Image>().sprite = karioki;
                counteroff();
            }
            else if (count4)
            {
                pic1.GetComponent<Image>().sprite = pic4.GetComponent<Image>().sprite;
                pic4.GetComponent<Image>().sprite = karioki;
                counteroff();
            }
            else
            {
                count1 = true;
            }

            //くりあしてるのか
            ClearCheck();
        }
        
        
    }
    
    public void pic2tap()
    {
        if (ClearFlag != true)
        {
            karioki = pic2.GetComponent<Image>().sprite;
            if (count1)
            {
                pic2.GetComponent<Image>().sprite = pic1.GetComponent<Image>().sprite;
                pic1.GetComponent<Image>().sprite = karioki;
                counteroff();
            }
            else if (count3)
            {
                pic2.GetComponent<Image>().sprite = pic3.GetComponent<Image>().sprite;
                pic3.GetComponent<Image>().sprite = karioki;
                counteroff();
            }
            else if (count4)
            {
                pic2.GetComponent<Image>().sprite = pic4.GetComponent<Image>().sprite;
                pic4.GetComponent<Image>().sprite = karioki;
                counteroff();
            }
            else
            {
                count2 = true;
            }
            ClearCheck();

        }
    }
    public void pic3tap()
    {
        if (ClearFlag != true)
        {
            karioki = pic3.GetComponent<Image>().sprite;
            if (count1)
            {
                pic3.GetComponent<Image>().sprite = pic1.GetComponent<Image>().sprite;
                pic1.GetComponent<Image>().sprite = karioki;
                counteroff();
            }
            else if (count2)
            {
                pic3.GetComponent<Image>().sprite = pic2.GetComponent<Image>().sprite;
                pic2.GetComponent<Image>().sprite = karioki;
                counteroff();
            }
            else if (count4)
            {
                pic3.GetComponent<Image>().sprite = pic4.GetComponent<Image>().sprite;
                pic4.GetComponent<Image>().sprite = karioki;
                counteroff();
            }
            else
            {
                count3 = true;
            }
            ClearCheck();
        }
        
    }
    public void pic4tap()
    {
        if (ClearFlag != true)
        {
            karioki = pic4.GetComponent<Image>().sprite;
            if (count1)
            {
                pic4.GetComponent<Image>().sprite = pic1.GetComponent<Image>().sprite;
                pic1.GetComponent<Image>().sprite = karioki;
                counteroff();
            }
            else if (count2)
            {
                pic4.GetComponent<Image>().sprite = pic2.GetComponent<Image>().sprite;
                pic2.GetComponent<Image>().sprite = karioki;
                counteroff();
            }
            else if (count3)
            {
                pic4.GetComponent<Image>().sprite = pic3.GetComponent<Image>().sprite;
                pic3.GetComponent<Image>().sprite = karioki;
                counteroff();
            }
            else
            {
                count4 = true;
            }
            ClearCheck();
        }
       
    }


}
