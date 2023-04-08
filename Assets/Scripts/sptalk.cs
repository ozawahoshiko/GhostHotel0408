using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sptalk : MonoBehaviour
{
    public GameObject spNormal;
    [SerializeField] Sprite spTalkimg,spNormalimg;
    // Start is called before the first frame update
    

    public void spTalkSt()
    {
        spNormal.GetComponent<Image>().sprite = spTalkimg;

    }
    public void spTalkEnd()
    {
        spNormal.GetComponent<Image>().sprite = spNormalimg;
    }
    
}
