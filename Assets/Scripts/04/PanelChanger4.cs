using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


public class PanelChanger4 : MonoBehaviour
{
    public GameObject RightArrow, LeftArrow, Up, Down;
    public Fungus.Flowchart flowchart = null;
    //�B��
    void HideArrows()
    {
        RightArrow.SetActive(false);
        LeftArrow.SetActive(false);
        Up.SetActive(false);
        Down.SetActive(false);

    }

    //���\��
    public void ArrowDisplay()
    {
        //�L�b�`��
        if (Mathf.Floor(this.transform.position.x) == 12)
        {
            HideArrows();
            RightArrow.SetActive(true);
        }
        else if (Mathf.Floor(this.transform.position.x) == 1 && Mathf.Floor(this.transform.position.y) == 11)
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
            LeftArrow.SetActive(true);
        }
        else
        {
            HideArrows();
            LeftArrow.SetActive(true);
            Down.SetActive(true);
        }

    }

    //�ŏ��̓���
    private void Start()
    {
        RightArrow.SetActive(false);
        LeftArrow.SetActive(false);
        Up.SetActive(false);
        Down.SetActive(false);

        this.transform.localPosition = new Vector2(3000, 3000);
    }

   
    //�p�l���ړ��֐�
    public void GoRight()
    {
        
        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.x += -1500f;
        this.transform.localPosition = localpos;
        ArrowDisplay();
        //�����o�Ă���~�߂�
        if (water.instance.CheckWater())
        {
            water.instance.HideWater();
        }


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
