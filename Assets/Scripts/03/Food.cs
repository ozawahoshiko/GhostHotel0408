using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//item�̂܂�
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
    //Slot�̉摜
    public Sprite sprite;

    public Food(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}
