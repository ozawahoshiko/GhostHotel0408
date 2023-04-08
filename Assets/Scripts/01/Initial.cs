using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Initial : MonoBehaviour
{
    public GameObject
        handazoom, RockStaffroom, fran;
       



    void HideRobbyObject()
    {
        handazoom.SetActive(false);
        RockStaffroom.SetActive(false);
        //owner.SetActive(false);
        fran.SetActive(false);


    }


    // Start is called before the first frame update
    void Start()
    {
        HideRobbyObject();
    }

 


    

}
