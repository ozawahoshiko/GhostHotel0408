using System;
using UnityEngine;


[Serializable]public class Item 
{
    public enum Name
    {
        bell=0,
        stick=1,
        straw=2,
        soot=3,
        coffina=4,
        coffinb = 5,
        nail=6,
        brush=7,
        poster=8,
        dqnum=9,
        handa=10,
        rockroom=11,
        mirror=12,
        sootCleaned=13,
        owner=14,
        turnlist=15,
        dartplate=16,
        draw=17,
        wolfsitting=18,
        cardbord=19,
        newspaper=20,
        drawnum=21,
        darts=22,
        plate=23,
        drawzoomb = 24,
        cardbordnum = 25,
        uniform=26,
        glass=27,
        shelf=28,
        memo=29,
        dish=30,
        cleanglass=31,
        moritukedai=32,
        bento1=33,
        bento2 = 34,
        bento3 = 35,
        cupboard=36,
        feed=37,
        statue=38,
        match=39,
        finger=40,
        cakememo=41,
        medicine=42,
        birthdish=43,
        birthdishb=44,
        spear=45,
        smallMirror=46,
        mummymemo=47,
        toybox = 48,
        toyboxopen = 49,
        doll = 50,
        dollStone = 51,
        mirrormemo = 52,
        book = 53,
        key = 54,
        picoji=55,
        bord=56,
        bordonSheet= 57,
        sheet=58,
        bats=59,
        hammer=60,
        truememo=61,
    }

    public Name name;
    //Slot�̉摜
    public Sprite sprite;

    public Item(Name name, Sprite sprite)
    {
        this.name = name;
        this.sprite = sprite;
    }


    
}
