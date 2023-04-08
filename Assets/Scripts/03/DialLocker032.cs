using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class DialLocker032 : MonoBehaviour
{//どこでも実行
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
    // 表示している画像
    public Image[] dialogs;

    //画像のソース
    public Sprite[] markSources;
    //マークの種類＋MAX
    enum Mark
    {
        no0 =0,
        no1 = 1,

        max =2,
    }
    //鍵の数
    Mark[] currentMarks =
    {
        Mark.no0,
        Mark.no0,
        Mark.no0,
        Mark.no0,
        Mark.no0,

    };
   

    bool count1 = false;//入力１回目
    bool count2 = false;//入力２回目
    bool count3 = false;//入力３回目
    bool count4 = false;//入力４回目
    bool count5 = false;//入力５回目


    //イベントを１度だけ起こす（発生したらtrueに切り替え）
    bool openfireflag = false;

    //15324が正かい
    //親指（一番左）
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
    //2番目
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
    //3番目
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
    //4番目
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
    //5番目
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
    //決定ボタン
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
            //ここに起こしたいイベントを書き込む
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                dialogs[i].sprite = markSources[0];
            }
           
        }
    }

    //効果音
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public bool CheckOpen()
    {
        return openfireflag;
    }
 
    

}
