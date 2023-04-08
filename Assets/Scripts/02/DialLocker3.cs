using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class DialLocker3 : MonoBehaviour
{//�ǂ��ł����s
    public static DialLocker3 instance;
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
        no2 = 2,
        no3 = 3,
        no4 = 4,
        no5 = 5,
        max=6,
    }
    //���̐�
    Mark[] currentMarks =
    {
        Mark.no0,
        Mark.no0,
        Mark.no0,

    };
    //�N���A����
    Mark[] clearMarks =
{       Mark.no1,
        Mark.no0,
        Mark.no0,

       /* Mark.no2,
        Mark.no4,
        Mark.no0,
        Mark.no6,
        */
    };

    //���ʉ�
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    //�{�^���N���b�N����
    public void OnClickDialog(int position)
    {
        ChangeMark(position);
        ShowMarkImage(position);
        audioSource.PlayOneShot(click);
        //�N���A�`�F�b�N
        if (IsClear() == true)
        {
            Cleared();
        }
    }
    //�N���A�Ƃ�
    bool IsClear()
    {
        if(currentMarks[0]== clearMarks[0]
            && currentMarks[1] == clearMarks[1]
            && currentMarks[2] == clearMarks[2]


            )
        {
            return true;
        }
        return false;
    }
    //�N���A�����Ƃ��̏���
    public bool opencbflag = false;
    void Cleared()
    {
        //�u���V�̕������Ă�
        flowchart.SendFungusMessage("cbopen");
        opencbflag = true;
      
    }

    public bool CheckOpen()
    {
        return opencbflag;
    }
    
   
    //�}�[�N�ϐ���ύX
    void ChangeMark(int position)
    {
        currentMarks[position]++;
        if (currentMarks[position] >= Mark.max)
        {
            currentMarks[position] = Mark.no0;
        }
    }

    //�}�[�N�ϐ��ɉ����ĉ摜�\��
    void ShowMarkImage(int position)
    {
        dialogs[position].sprite = GetSource(currentMarks[position]);
    }
     Sprite GetSource(Mark mark)
    {
        int markIndex = (int)mark;
        return markSources[markIndex];
    }
    
   
}
