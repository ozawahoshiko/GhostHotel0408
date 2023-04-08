using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger13 : MonoBehaviour
{
    public GameObject RightArrow, LeftArrow, Up, Down;

    //âBÇ∑
    void HideArrows()
    {
        RightArrow.SetActive(false);
        LeftArrow.SetActive(false);
        Up.SetActive(false);
        Down.SetActive(false);

    }

    //ñÓàÛï\é¶
    public void ArrowDisplay()
    {
        if (Mathf.Floor(this.transform.position.x) == 1 && Mathf.Floor(this.transform.position.y) == 11)
        {
            HideArrows();
            Up.SetActive(true);
        }
        else if (Mathf.Floor(this.transform.position.x) == 6 && Mathf.Floor(this.transform.position.y) == -1)
        {
            HideArrows();
            RightArrow.SetActive(true);
        }
        else
        {
            HideArrows();
            LeftArrow.SetActive(true);
            Down.SetActive(true);
        }

    }

    //ç≈èâÇÃìÆçÏ
    private void Start()
    {
        RightArrow.SetActive(false);
        LeftArrow.SetActive(false);
        Up.SetActive(false);
        Down.SetActive(false);

        this.transform.localPosition = new Vector2(1500, 0);
    }


    //ÉpÉlÉãà⁄ìÆä÷êî
    public void GoRight()
    {
        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.x += -1500f;
        this.transform.localPosition = localpos;
        ArrowDisplay();



    }
    public void GoLeft()
    {
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
