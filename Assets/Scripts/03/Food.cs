using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//item‚Ì‚Ü‚Ë
public class Food : MonoBehaviour
{
    public enum Type
    {
        food0 = 0,
        food1 = 1,
        food2 = 2,
        food3 = 3,

    }
    public Type type;
    //Slot‚Ì‰æ‘œ
    public Sprite sprite;

    public Food(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}
