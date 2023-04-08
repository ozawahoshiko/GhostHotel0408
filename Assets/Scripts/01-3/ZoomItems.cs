using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomItems : MonoBehaviour
{ //どこでも実行
    public static ZoomItems instance;
    GameObject[] zooms = new GameObject[30];
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
   
    //文言表示が終わったらブロック隠して、表示されているZOOMだけ消す
    public void HideZoom()
    {
        BlockBG.instance.HideBlock();

        // 各要素へ検索し取得してきたGameObjectを代入
        zooms[0] = GameObject.Find("posterzoom");
        zooms[1] = GameObject.Find("fireplacezooma");
        zooms[2] = GameObject.Find("dqnumzoom");
        zooms[3] = GameObject.Find("coffinzoom");
        zooms[4] = GameObject.Find("mirroerzoom");
        zooms[5] = GameObject.Find("RockStaffroom");
        zooms[6] = GameObject.Find("handazoom");
        zooms[7] = GameObject.Find("fireplacezoomb");
        zooms[8] = GameObject.Find("turnlistzoom");
        zooms[9] = GameObject.Find("drawzooma");
        zooms[10] = GameObject.Find("cardboardzooma");
        zooms[11] = GameObject.Find("dartzoom");
        zooms[12] = GameObject.Find("drawnumzoom");
        zooms[13] = GameObject.Find("cardboardnumzoom");
        zooms[14] = GameObject.Find("shelfzooma");
        zooms[15] = GameObject.Find("shelfnumzoom");
        zooms[16] = GameObject.Find("cupbzooma");
        zooms[17] = GameObject.Find("cupbnumzoom");
        zooms[18] = GameObject.Find("memozoom");
        zooms[19] = GameObject.Find("fpzooma");
        zooms[20] = GameObject.Find("fpnumzoom");
        zooms[21] = GameObject.Find("handanime");
        zooms[22] = GameObject.Find("spearzooma");
        zooms[23] = GameObject.Find("toyboxnumzoom");
        zooms[24] = GameObject.Find("picOjizoom");
        zooms[25] = GameObject.Find("picOjinumzoom");
        zooms[26] = GameObject.Find("picOjopen");
        zooms[27] = GameObject.Find("batszoom");
        zooms[28] = GameObject.Find("batsnumzoom");
        zooms[29] = GameObject.Find("hummeropen");
        foreach (GameObject i in zooms)
        {
            if (i != null)
            {
                i.SetActive(false);
            }

        }
        

    }
    public void ShowAllZoom()
    {
        gameObject.SetActive(true);

    }
    //#2で追加
    public void HideOpendrawers()
    {
        if (GameObject.Find("drawzoomb")!=null) {
            GameObject.Find("drawzoomb").SetActive(false);
        } }
    public void HideOpencb()
    {
        if (GameObject.Find("cardboardzoomb") != null)
        {
            GameObject.Find("cardboardzoomb").SetActive(false);
        }
    }
    //#3で追加
    public void HideOpendShelf()
    {
        if (GameObject.Find("shelfzoomb") != null)
        {
            GameObject.Find("shelfzoomb").SetActive(false);
        }
    }
    public void HideOpendCupBoard()
    {
        if (GameObject.Find("cupbzoomb") != null)
        {
            GameObject.Find("cupbzoomb").SetActive(false);
        }
    }
    //#3で追加
    public void HideOpendFirePlace()
    {
        if (GameObject.Find("fpzoomb") != null)
        {
            GameObject.Find("fpzoomb").SetActive(false);
        }
    }

    //#7で追加
    public void HidepicOji()
    {
        if (GameObject.Find("picOjopen") != null)
        {
            GameObject.Find("picOjopen").SetActive(false);
        }
    }
    //#8で追加
    public void HideBat()
    {
        if (GameObject.Find("hummeropen") != null)
        {
            GameObject.Find("hummeropen").SetActive(false);
        }
    }
}
