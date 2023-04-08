using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBg: MonoBehaviour
{
    public static ItemBg instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void DisplayItem()
    {
        gameObject.SetActive(true);
    }
    public void HideItem()
    {
        gameObject.SetActive(false);
    }
    

    public bool ZoomItemActiveCheck()
    {
        return gameObject.activeSelf;
    }

    
}

  


