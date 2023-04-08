using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




    public class Slot13 : MonoBehaviour
    {
        //取得して画像表示

        Item item;
        [SerializeField] Image image;
        [SerializeField] GameObject turnedOn;
        

        public GameObject itemImage;

     

        private void Awake()
        {
            //image = GetComponent<Image>();
        }

        private void Start()
        {
            turnedOn.SetActive(false);
        }

        public bool IsEmpty()
        {
            if (item == null)
            {
                return true;
            }
            return false;
        }

        public void SetItem(Item item)
        {
            //Slot自身にアイテムをもたせる
            this.item = item;
            ShowImage(item);

        }
        //渡す
        public Item GetItem()
        {
            return item;
        }

        //アイテム受け取り画像表示
        void ShowImage(Item item)
        {
            if (item == null)
            {
                image.sprite = null;
            }
            else
            {
                itemImage.GetComponent<Image>().color = Color.white;
                image.sprite = item.sprite;
            }


        }

        //スロットクリック時

        public bool OnclickSlot()
        {
            if (item == null)
            {
                return false;
            }

            return true;
        }

        public void turnOn()
        {
            turnedOn.SetActive(true);
        }

        //スロットクリック時
        public void HideTurnedOn()
        {
            turnedOn.SetActive(false);


        }
    }


