using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{
    public GameObject RightArrow;
    public GameObject LeftArrow;
    public GameObject Up;
    public GameObject Down;

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
    {//キッチン
        if (Mathf.Floor(this.transform.position.x) == 12)
        {
            HideArrows();
            RightArrow.SetActive(true);
        }//スタッフルーム
        else if (Mathf.Floor(this.transform.position.x) == 6 && Mathf.Floor(this.transform.position.y) == 11)
        {
            HideArrows();
            RightArrow.SetActive(true);
            LeftArrow.SetActive(true);
        }//フロント
        else if (Mathf.Floor(this.transform.position.x) == 1 && Mathf.Floor(this.transform.position.y) == 11)
        {
            HideArrows();
            LeftArrow.SetActive(true);
            Up.SetActive(true);
        }//ドラキュラ
        else if (Mathf.Floor(this.transform.position.x) == 6 && Mathf.Floor(this.transform.position.y) == -1)
        {
            HideArrows();
            RightArrow.SetActive(true);
        }//ろうか
        else if (Mathf.Floor(this.transform.position.x) == 1 && Mathf.Floor(this.transform.position.y) == -1)
        {
            RightArrow.SetActive(true);
            LeftArrow.SetActive(true);
            Up.SetActive(true);
            Down.SetActive(true);
        }//絵画
        else if (Mathf.Floor(this.transform.position.x) == 1 && Mathf.Floor(this.transform.position.y) == -12)
        {
            HideArrows();
            RightArrow.SetActive(true);
            Down.SetActive(true);
        }
        else
        {
            HideArrows();
            LeftArrow.SetActive(true);
        }
    }

    //最初の動作
    private void Start()
    {
        RightArrow.SetActive(false);
        LeftArrow.SetActive(true);
        Up.SetActive(true);
        Down.SetActive(false);

        this.transform.localPosition = new Vector2(0, 3000);
    }


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
    {
        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;

        if (Mathf.Floor(this.transform.position.x) == -11)
        {
            localpos.x += 3000f;
        }
        else
        {
            localpos.x += 1500f;   
        }
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
    public void OnSwitch()
    {
        this.transform.localPosition = new Vector2(-3000, 0);
        ArrowDisplay();
    }


   
   

}
