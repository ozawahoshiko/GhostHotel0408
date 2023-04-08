using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
using UnityEngine.SceneManagement;



public class ZoomItem: MonoBehaviour
{
    [SerializeField] private string loadScene;
    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 1.0f;

    //  public static ItemBg instance;
    public GameObject itemBg;
    Image image;
    Item itemm = null;

    public AudioClip bellring;
    AudioSource audioSource;

    public static ZoomItem instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        itemBg.SetActive(false);
        image = GetComponent<Image>();
        audioSource = GetComponent<AudioSource>();
    }



    //取得して画像表示
    public void SetZoomItem(Item item)
    {
        ShowZoomImage(item);

    }

    //Item渡す
    public Item CheckZoomItem()
    {
        return itemm;

    }

    //アイテム受け取り画像表示
    public void ShowZoomImage(Item item)
    {
        if (item != null)
        {
            itemBg.SetActive(true);
            this.gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            //this.gameObject.GetComponent<Image>().color = Color.red;
            image.sprite = item.sprite;
            itemm = item;
        }
        
        

    }
    //int num = 0;

    //けしたりするやつ
    public void HideItemBg()
    {
        itemBg.SetActive(false);
        BlockBG.instance.HideBlock();
        //Debug.Log(Fungus.DialogInput.instance.CheckEndText()+"でとるで");

    }

    
    //効果音
    bool endflag = false;
        public void setendflag()
    {
        endflag = true;
    }

    public void CallFran()
    {
        if (endflag)
        {
            audioSource.PlayOneShot(bellring);
            Invoke(nameof(ChangeScene), 1.5f);
            

        }
       
        
    }
    public void ChangeScene()
    {
        Initiate.Fade(loadScene, fadeColor, fadeSpeedMultiplier);
    }
    // Fungus.DialogInput.instance.SetButtonClickedFlag();}

    
}

