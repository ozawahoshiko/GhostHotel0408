using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




    public class Slot13 : MonoBehaviour
    {
        //�擾���ĉ摜�\��

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
            //Slot���g�ɃA�C�e������������
            this.item = item;
            ShowImage(item);

        }
        //�n��
        public Item GetItem()
        {
            return item;
        }

        //�A�C�e���󂯎��摜�\��
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

        //�X���b�g�N���b�N��

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

        //�X���b�g�N���b�N��
        public void HideTurnedOn()
        {
            turnedOn.SetActive(false);


        }
    }


