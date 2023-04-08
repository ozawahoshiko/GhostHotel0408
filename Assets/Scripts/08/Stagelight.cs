using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stagelight : MonoBehaviour
{
    [SerializeField] GameObject bg;
    [SerializeField] Sprite showtime;
    public void LightOff()
    {
        bg.GetComponent<Image>().sprite = showtime;
    }
}
