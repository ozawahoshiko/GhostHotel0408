using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfControl : MonoBehaviour
{//‚Ç‚±‚Å‚àÀs
    public static wolfControl instance;
    GameObject[] zooms = new GameObject[22];
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    [SerializeField] GameObject wolfstand,wolfsit;
    bool wolfMessageSend = false;
//ŒÄ‚Î‚ê‚Äo‚Ä‚­‚é
    public void ShowStand()
    {
        wolfstand.SetActive(true);
    }

    public void SitDown()
    {
        wolfstand.SetActive(false);
        wolfsit.SetActive(true);
        wolfMessageSend = true;
    }
    //˜T‚Ì“`’B‚¨‚í‚Á‚Ä‚é‚©
    public bool MessageCheck()
    {
        return wolfMessageSend;
    }

    public void SetFalse()
    {
        wolfMessageSend = false;
    }
}
