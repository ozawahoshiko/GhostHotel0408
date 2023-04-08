using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class OpenDrawer4 : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    
    [SerializeField] GameObject openfp;
    [SerializeField] GameObject opencpb;



    public void Openfp()
     {
         openfp.SetActive(true);
        
    }
    public void Opencpb()
    {
        opencpb.SetActive(true);

    }


}
