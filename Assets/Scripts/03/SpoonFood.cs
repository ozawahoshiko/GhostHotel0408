using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoonFood : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);  
    }

    // Update is called once per frame
    public void ShowSp()
    {
        gameObject.SetActive(true);

    }
    public void HideSp()
    {
        gameObject.SetActive(false);
    }
}
