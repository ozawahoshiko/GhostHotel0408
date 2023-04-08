using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class TurnList : MonoBehaviour
{
    [SerializeField] Item.Name clearItem;
    public Fungus.Flowchart flowchart = null;
    [SerializeField] GameObject showItem1;
    [SerializeField] GameObject showItem2;
    [SerializeField] GameObject showItem3;
    [SerializeField] Slot[] slots;
    Item useditem;
    // �\�����Ă���摜
    public Image dialogs;

    //�摜�̃\�[�X
    public Sprite[] markSources;
    //�}�[�N�̎�ށ{MAX
    enum Mark
    {
        no0 = 0,
        no1 = 1,
        no2 = 2,
        no3 = 3,
        no4 = 4,
        no5 = 5,
        max = 6,
    }
    //���̐�
    Mark currentMarks = Mark.no0;

    

    public void TurnListSet()
    {
        //�N���b�N������
        bool clear = ItemBox13.instance.TryUseItem(clearItem);
        //�����X���b�g�摜��clearItem(�~��)���͂����Ă����
        if (clear == true)
        {
            //�u���V�̕������ĂԁA�t���O������
            flowchart.SetBooleanVariable("turnlist", true);
            flowchart.SendFungusMessage("turnlist");

        }
    }
    bool plateSeted = false;
    //�|���ł������Azoom�A�C�e�����o��
    public void Callplate()
    {
        HideUsedItems();
        showItem1.SetActive(true);
        showItem2.SetActive(true);
        showItem3.SetActive(true);
        plateSeted = true;
    }
    public void HideUsedItems()
    {
        foreach (Slot slot in slots)
        {
            //Debug.Log(fordebug);
            useditem = slot.GetItem();
            //fordebug++;
            if (useditem != null)
            {
                if ((int)useditem.name == 23)
                {
                    slot.SetItem(null);
                    slot.ColorChange();
                }
            }

        }

    }

    //�~�Ղ��Z�b�g���ꂽ��ԂŃN���b�N������
    public void OnclickPlate()
    {
        if (plateSeted)
        {
            ChangeMark();
            ShowMarkImage();
            //audioSource.PlayOneShot(click);
           
        }
    }
    //�}�[�N�ϐ���ύX
    void ChangeMark()
    {
        currentMarks++;
        if (currentMarks >= Mark.max)
        {
            currentMarks = Mark.no0;
        }
    }
    //�}�[�N�ϐ��ɉ����ĉ摜�\��
    void ShowMarkImage()
    {
        dialogs.sprite = GetSource(currentMarks);
    }
    Sprite GetSource(Mark mark)
    {
        int markIndex = (int)mark;
        return markSources[markIndex];
    }
    
}
