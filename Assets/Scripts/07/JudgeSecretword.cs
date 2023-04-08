using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using Fungus;
public class JudgeSecretword : MonoBehaviour
{
    string secretword = null;
    //�I�u�W�F�N�g�ƌ��т���
    [SerializeField] GameObject secretwords;
    public InputField inputField;
    static Encoding shiftjisEnc = Encoding.GetEncoding("Shift_JIS");
    public Fungus.Flowchart flowchart = null;


    void Start()
    {
        //Component��������悤�ɂ���
        inputField = inputField.GetComponent<InputField>();
        //inputField.Select();
        //text = text.GetComponent<Text>();

    }
    public void ShowField()
    {
        secretwords.SetActive(true);
        BlockBG.instance.ShowBlock();
    }
    //�S�p���ǂ���
    public static bool isFullWitdh(string chkStr)
    {
        int chrByteNum = shiftjisEnc.GetByteCount(chkStr);
        bool isAllFullWidth = (chrByteNum == chkStr.Length * 2);
        return isAllFullWidth;
    }

    //������
    public static int numFullWidth(string chkStr)
    {
        int chrByteNum = shiftjisEnc.GetByteCount(chkStr);
        int numFullWidth = chrByteNum - chkStr.Length;
        return numFullWidth;
    }
    public void CheckLine()
    {
        secretword = inputField.text;
        if (isFullWitdh(secretword) && numFullWidth(secretword) == 6)
        {
            Debug.Log(secretword);
            if (secretword == "���ł悠����")
            {
                flowchart.SendFungusMessage("trueword");
                HideUsedItem.instance.HideUsedItems(53);
                HideUsedItem.instance.HideUsedItems(56);
                HideUsedItem.instance.HideUsedItems(57);
            }
            else
            {
                flowchart.SendFungusMessage("falseword");
            }

        }
        else
        {
            flowchart.SendFungusMessage("falseword");
        }
        
        secretwords.SetActive(false);
        //BlockBG.instance.HideBlock();
    }

    

}
