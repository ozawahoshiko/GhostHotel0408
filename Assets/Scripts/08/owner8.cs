using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class owner8 : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    [SerializeField]Item truememo;
    bool passedmemo = false;

    public static owner8 instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void OnclickOwner()
    {
        if (passedmemo!=true)
        {
            flowchart.SendFungusMessage("owner");
            passedmemo = true;
        }
        
       

    }
    public bool CheckPassed()
    {
        return passedmemo;
    }
    public void HideOwner()
    {
        gameObject.SetActive(false);
    }

    public void PassMemo()
    {
        ItemBox13.instance.SetItem(truememo);
       
        //BlockBG.instance.ShowBlock();
    }
}
