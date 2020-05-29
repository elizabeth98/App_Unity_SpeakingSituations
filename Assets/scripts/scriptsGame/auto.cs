using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class auto : MonoBehaviour
{

    public GameObject prefabIns;
    public GameObject objetoPadre;

    void Start()
    {

      
    }

    // Update is called once per frame
    void Update()
    {

        Quaternion rotation = objetoPadre.transform.rotation;
        prefabIns.transform.rotation = rotation;

       

    }
}
