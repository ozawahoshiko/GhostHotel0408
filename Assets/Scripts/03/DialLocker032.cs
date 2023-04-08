using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class DialLocker032 : MonoBehaviour
{//�ǂ��ł����s
    public static DialLocker032 instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public AudioClip click;
    AudioSource audioSource;
 
    public Fungus.Flowchart flowchart = null;
    // �\�����Ă���摜
    public Image[] dialogs;

    //�摜�̃\�[�X
    public Sprite[] markSources;
    //�}�[�N�̎�ށ{MAX
    enum Mark
    {
        no0 =0,
        no1 = 1,

        max =2,
    }
    //���̐�
    Mark[] currentMarks =
    {
        Mark.no0,
        Mark.no0,
        Mark.no0,
        Mark.no0,
        Mark.no0,

    };
   

    bool count1 = false;//���͂P���
    bool count2 = false;//���͂Q���
    bool count3 = false;//���͂R���
    bool count4 = false;//���͂S���
    bool count5 = false;//���͂T���


    //�C�x���g���P�x�����N�����i����������true�ɐ؂�ւ��j
    bool openfireflag = false;

    //15324��������
    //�e�w�i��ԍ��j
    public void button1tap()
    {
        /*for(int i = 0; i< 5; i++)
        {
            dialogs[i].sprite = GetSource(currentMarks[0]);
        }*/
        dialogs[0].sprite = markSources[1];

        count1 = true;
        count2 = false;
        count3 = false;
        count4 = false;
         count5 = false;
        
    }
    //2�Ԗ�
    public void button2tap()

    {
        /*for (int i = 0; i < 5; i++)
        {
            dialogs[i].sprite = GetSource(currentMarks[0]);
        }
        */
        dialogs[1].sprite = markSources[1];
        if (count3 == true)
        {
            count3 = false;
            count4 = true;
        }
        else
        {
            count1 = false;
            count2 = false;
            count3 = false;
            count4 = false;
            count5 = false;
        }
    }
    //3�Ԗ�
    public void button3tap()
    {
        /*for (int i = 0; i < 5; i++)
        {
            
        }*/
        dialogs[2].sprite = markSources[1];
        if (count2 == true)
        {
            count2 = false;
            count3 = true;
        }
        else
        {
            count1 = false;
            count2 = false;
            count3 = false;
            count4 = false;
            count5 = false;
        }
    }
    //4�Ԗ�
    public void button4tap()
    {
        /*for (int i = 0; i < 5; i++)
        {
            
        }*/
        dialogs[3].sprite = markSources[1];
        if (count4 == true)
        {
            count4 = false;
            count5 = true;
        }
        else
        {
            count1 = false;
            count2 = false;
            count3 = false;
            count4 = false;
            count5 = false;
        }
    }
    //5�Ԗ�
    public void button5tap()
    {
 
        dialogs[4].sprite = markSources[1];
        if (count1 == true)
        {
            count1 = false;
            count2 = true;
        }
        else
        {
            count1 = false;
            count2 = false;
            count3 = false;
            count4 = false;
            count5 = false;
        }
    }
    //����{�^��
    public void enterbuttontap()
    {
        if (count5 == true && openfireflag == false)
        {
           
            
            for (int i = 0; i < 5; i++)
            {
                dialogs[i].sprite = markSources[0];
            }
            flowchart.SendFungusMessage("opencpb");
            openfireflag = true;
            // HideUsedItem.instance.HideUsedItems(37);
            //�����ɋN���������C�x���g����������
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                dialogs[i].sprite = markSources[0];
            }
           
        }
    }

    //���ʉ�
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public bool CheckOpen()
    {
        return openfireflag;
    }
 
    

}
