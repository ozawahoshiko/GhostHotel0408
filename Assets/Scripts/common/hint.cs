using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hint : MonoBehaviour
{
    [SerializeField] GameObject hintpanel;
    public void Start()
    {
        hintpanel.SetActive(false);
    }

   
    public void Close()
    {
        hintpanel.SetActive(false);
    }
    public void Open()
    {
        hintpanel.SetActive(true);
        Debug.Log("drh");
    }
}
