using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


public class PanelChanger2 : MonoBehaviour
{
    public GameObject RightArrow, LeftArrow, Up, Down,fran;
    public Fungus.Flowchart flowchart = null;
    //隠す
    void HideArrows()
    {
        RightArrow.SetActive(false);
        LeftArrow.SetActive(false);
        Up.SetActive(false);
        Down.SetActive(false);

    }

    //矢印表示
    public void ArrowDisplay()
    {
        if (Mathf.Floor(this.transform.position.x) == 1 && Mathf.Floor(this.transform.position.y) == 11)
        {
            HideArrows();
            Up.SetActive(true);
            LeftArrow.SetActive(true);
        }
        else if (Mathf.Floor(this.transform.position.x) == 6 && Mathf.Floor(this.transform.position.y) == -1)
        {
            HideArrows();
            RightArrow.SetActive(true);
        }
        else if (Mathf.Floor(this.transform.position.x) == 6 && Mathf.Floor(this.transform.position.y) == 11)
        {
            HideArrows();
            RightArrow.SetActive(true);
            //LeftArrow.SetActive(true);
        }
        else
        {
            HideArrows();
            LeftArrow.SetActive(true);
            Down.SetActive(true);
        }

    }

    //最初の動作
    private void Start()
    {
        RightArrow.SetActive(false);
        LeftArrow.SetActive(false);
        Up.SetActive(false);
        Down.SetActive(false);

        this.transform.localPosition = new Vector2(0, 3000);
    }

    public bool isFistTIme = true; 
    //パネル移動関数
    public void GoRight()
    {
        
        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.x += -1500f;
        this.transform.localPosition = localpos;
        ArrowDisplay();



    }
    public void GoLeft()
    {   //初めてスタッフルームに入ったとき言う
        
        if (isFistTIme&& Mathf.Floor(this.transform.position.x) == 1 && Mathf.Floor(this.transform.position.y) == 11)
        {
            flowchart.SendFungusMessage("firstroom");
            fran.SetActive(false);
            isFistTIme = false;
        }
        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.x += 1500f;
        this.transform.localPosition = localpos;
        ArrowDisplay();
    }
    public void GoUp()
    {
        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.y += -3000f;
        this.transform.localPosition = localpos;
        ArrowDisplay();
    }
    public void GoDown()
    {
        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.y += 3000f;
        this.transform.localPosition = localpos;
        ArrowDisplay();

    }


}
