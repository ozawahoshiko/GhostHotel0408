using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    public bool waterRun = false;
    public static water instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void ShowWater()
    {
        if (GameObject.Find("water"))
        {
            HideWater();
            
        }
        else
        {
            gameObject.SetActive(true);
            SoundMaker.instance.Sound();
            waterRun = true;
        }
       
    }
    public void HideWater()
    {
        gameObject.SetActive(false);
        SoundMaker.instance.Stop();
        waterRun = false;
    }

    public bool CheckWater()
    {
        return waterRun;
    }
}
