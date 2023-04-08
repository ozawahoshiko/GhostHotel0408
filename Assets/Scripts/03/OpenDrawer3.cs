using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class OpenDrawer3 : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    
    [SerializeField] GameObject opensh;
    [SerializeField] GameObject opencpb;



    public void Opensh()
     {
         opensh.SetActive(true);
        
    }
    public void Opencpb()
    {
        opencpb.SetActive(true);
       
    }
 

}
