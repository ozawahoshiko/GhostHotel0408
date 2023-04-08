using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class PickUpObject13 : MonoBehaviour
{
    //�ǂ��ł����s
    public static PickUpObject13 instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    [SerializeField] Item.Name itemName;
    Item item;
       //�X�^�[�g���ɏ��Ƃ��Ă���
    private void Start()
    {
        //itemType�ɉ�����item�𐶐�����
        item = ItemGenerater.instance.Spawn(itemName);
    }

    //�N���b�N���������
    public void OnClickObj()
    {
        ItemBox13.instance.SetItem(item);
        gameObject.SetActive(false);
        BlockBG.instance.ShowBlock();
    }
    
}
