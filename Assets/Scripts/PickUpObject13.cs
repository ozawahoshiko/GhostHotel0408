using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class PickUpObject13 : MonoBehaviour
{
    //どこでも実行
    public static PickUpObject13 instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    [SerializeField] Item.Name itemName;
    Item item;
       //スタート時に情報とってくる
    private void Start()
    {
        //itemTypeに応じてitemを生成する
        item = ItemGenerater.instance.Spawn(itemName);
    }

    //クリックしたら消す
    public void OnClickObj()
    {
        ItemBox13.instance.SetItem(item);
        gameObject.SetActive(false);
        BlockBG.instance.ShowBlock();
    }
    
}
