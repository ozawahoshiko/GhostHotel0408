using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;
using UnityEngine.UI;

public class Initial12: MonoBehaviour
{
    public GameObject
          fran;
    public Fungus.Flowchart flowchart = null;
    [SerializeField] private string loadScene;


    void HideRobbyObject()
    {
        
        fran.SetActive(false);
        

    }

    public void CallHer()
    {
        fran.SetActive(true);
       
    }


    // Start is called before the first frame update
    void Start()
    {
        HideRobbyObject();
       // flowchart.SendFungusMessage("test");
    }

    public void ChangeScene()
    {
        Initiate.Fade(loadScene, Color.black, 1.0f);
    }




}
