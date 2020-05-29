using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnHelp : MonoBehaviour
{
    public GameObject pestanaHelp1;
    public GameObject pestanaHelp2;
    public GameObject btnCerrar;
    public GameObject btnSig;
    // Start is called before the first frame update
   

    // Update is called once per frame
    public void abrirhelp1()
    {
        pestanaHelp1.SetActive(true);
        pestanaHelp2.SetActive(false);
        btnCerrar.SetActive(true);
        btnSig.SetActive(true);
    }

    public void abrirhelp2()
    {
        pestanaHelp2.SetActive(true);
        pestanaHelp1.SetActive(false);
        btnCerrar.SetActive(true);
        btnSig.SetActive(false);
    }

    public void CerrarHelp()
    {
        pestanaHelp2.SetActive(false);
        pestanaHelp1.SetActive(false);
        btnCerrar.SetActive(false);
        btnSig.SetActive(false);
    }
}
