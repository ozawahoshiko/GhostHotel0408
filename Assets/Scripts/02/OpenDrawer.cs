using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class OpenDrawer : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    [SerializeField] GameObject opendrawer;
    [SerializeField] GameObject opencb;
    public void Opendrawer()
    {
        opendrawer.SetActive(true);
        //flowchart.SetBooleanVariable("unlockflag", true);
    }
    public void Opencb()
    {
        opencb.SetActive(true);

    }
    /* public void Opensh()
     {
         opensh.SetActive(true);

     }
    */
}
