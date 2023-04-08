using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dartAnima : MonoBehaviour
{
    private Vector3 pos;
    //Vector2(0, 3000)

    //Animator animator;
    // Start is called before the first frame update
    void Start()
    {
       //pos = new Vector3(5, 5, 5);
        
    }

    public void Update()
    {
        pos = transform.position;
        if (dartshoot.instance.SetDartFlag()){
            if (pos.x > 1.58f)
            {
                transform.Translate(-0.18f, -0.09f, 0);
            }
            

        }


    }
}
