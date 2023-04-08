using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statue : MonoBehaviour
{
    [SerializeField] Item.Name clearItem;
    //public GameObject itemImage;
    // �����ꂽ���A�A�C�e���������Ă���ΐF�𔒂ɂ��ăA�C�e��������
    public void Onclick()
    {
        bool clear = ItemBox13.instance.TryUseItem(clearItem);
        if (clear)
        {
            this.GetComponent<Image>().color = Color.white;
            HideUsedItem.instance.HideUsedItems((int)clearItem);

           
        }
    }

    //�����}�b�`�����������ɑ����A�C�e�����ɂ���Ώ����ăA�C�e���o��

    public void SetStatue()
    {
        if (ItemBox13.instance.CheckItemAllBox(clearItem))
        {
            this.GetComponent<Image>().color = Color.white;
            HideUsedItem.instance.HideUsedItems((int)clearItem);
        }
    }
    
}
