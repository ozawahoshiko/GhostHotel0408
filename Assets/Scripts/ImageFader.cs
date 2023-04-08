using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFader : MonoBehaviour
{
    GameObject me; // �����̃I�u�W�F�N�g�擾�p�ϐ�
    public float fadeStart = 2f; // �t�F�[�h�J�n����
    public bool fadeIn = true; // true�̏ꍇ�̓t�F�[�h�C��
    public float fadeSpeed = 1f; // �t�F�[�h���x�w��

    //�ǂ��ł����s
    public static ImageFader instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        me = this.gameObject; // �����̃I�u�W�F�N�g�擾
    }
    bool tff = false;
    public void GetActive(bool tf)
    {
        tff= tf;
    }
    public bool SetActive()
    {
        return tff;
    }
    // Update is called once per frame
    void Update()
    {
        if (SetActive())
        {
            if (fadeStart > 0f)
            {
                fadeStart -= Time.deltaTime;
            }
            else
            {
                if (fadeIn)
                {
                    fadeInFunc();
                }
            }
        }
       
    }

    void fadeInFunc()
    {
        if (me.GetComponent<Image>().color.a < 255)
        {

            UnityEngine.Color tmp = me.GetComponent<Image>().color;
            tmp.a = tmp.a + (Time.deltaTime * fadeSpeed);
            me.GetComponent<Image>().color = tmp;
        }
    }
}
