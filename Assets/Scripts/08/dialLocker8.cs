using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class dialLocker8 : MonoBehaviour
{
    public AudioClip click;
    AudioSource audioSource;
    [SerializeField] GameObject hummeropen;

    public Fungus.Flowchart flowchart = null;
    // 表示している画像
    public Image[] dialogs;

    public static dialLocker8 instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    //画像のソース
    public Sprite[] markSources;
    //マークの種類＋MAX
    enum Mark
    {
        no0 = 0,
        no1 = 1,
        no2 = 2,
        no3 = 3,
        max = 4,
    }
    //鍵の数
    Mark[] currentMarks =
    {
        Mark.no0,
        Mark.no0,
        Mark.no0,
        Mark.no0,


    };
    //クリア条件
    Mark[] clearMarks =
{       Mark.no1,
        Mark.no0,
        Mark.no0,
        Mark.no0,

    };
    //効果音
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    //ボタンクリック処理
    public void OnClickDialog(int position)
    {
        ChangeMark(position);
        ShowMarkImage(position);
        audioSource.PlayOneShot(click);
        //クリアチェック
        if (IsClear() == true)
        {
            Cleared();
        }
    }
    //クリアとは
    bool IsClear()
    {
        if (currentMarks[0] == clearMarks[0]
            && currentMarks[1] == clearMarks[1]
            && currentMarks[2] == clearMarks[2]
             && currentMarks[3] == clearMarks[3]

            )
        {
            return true;
        }
        return false;
    }
    //クリアしたときの処理
    public bool openshflag = false;
    void Cleared()
    {
        flowchart.SendFungusMessage("batopen");
      
        openshflag = true;
        hummeropen.SetActive(true);
       gameObject.SetActive(false);

        flowchart.SetBooleanVariable("unlockflag", true);
        
    }

    public bool CheckOpen()
    {
        return openshflag;
    }


    //マーク変数を変更
    void ChangeMark(int position)
    {
        currentMarks[position]++;
        if (currentMarks[position] >= Mark.max)
        {
            currentMarks[position] = Mark.no0;
        }
    }

    //マーク変数に応じて画像表示
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
