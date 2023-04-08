using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gortalk : MonoBehaviour
{
    public GameObject gorgon;
    [SerializeField] Sprite gornomal, gorTalk;
    // Start is called before the first frame update


    public void spTalkSt()
    {
        gorgon.GetComponent<Image>().sprite = gorTalk;

    }
    public void spTalkEnd()
    {
        gorgon.GetComponent<Image>().sprite = gornomal;
    }
}
