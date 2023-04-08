using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBG : MonoBehaviour
{
    public void HideBlock()
    {
        BlockBG.instance.HideBlock();
    }
    public void ShowBlock()
    {
        BlockBG.instance.ShowBlock();
    }
}
