using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hands : MonoBehaviour
{
    [SerializeField] Item.Name finger;
    [SerializeField] Item.Name match;

    [SerializeField] private GameObject hand;
    [SerializeField] private GameObject handbzoom;
    [SerializeField] private Sprite fullhand;
    


    bool fingerset = false;
    bool matchUsed = false;
    public void OnclickHand()
    {
        bool clear = ItemBox13.instance.TryUseItem(finger);
        bool clear2 = ItemBox13.instance.TryUseItem(match);

      //��уZ�b�g�ς݂̂Ƃ�
        if (fingerset)
        {
            //�}�b�`�g���ς݂Ȃ�
            if (matchUsed)
            {
                //�A�j���[�V�����J�n
                handbzoom.SetActive(true);
                handsAnime.instance.StartHandAnime();
            }
            else
            {
                //�}�b�`�������
                if (clear2)
                {
                    //�A�j���[�V�����J�n
                    handbzoom.SetActive(true);
                    handsAnime.instance.StartHandAnime();
                    //�}�b�`����
                    HideUsedItem.instance.HideUsedItems((int)match);
                    matchUsed = true;
                }
            }
            

         }
        else
        {  //�N���b�N�����Ƃ��A������т������Ă���΁A
           //�Y�[���摜�ɍ����ւ���
           //�����Ă���w�̉摜�����ւ��鍷���ւ���A
           //�g�����w������
            if (clear)
            {
                hand.GetComponent<Image>().sprite = fullhand;
                this.GetComponent<Image>().sprite = handbzoom.GetComponent<Image>().sprite;
                HideUsedItem.instance.HideUsedItems((int)finger);
               
                fingerset = true;

            }
        }
        
        
    }

}
