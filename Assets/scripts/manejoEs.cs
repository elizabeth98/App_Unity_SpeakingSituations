using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class manejoEs: MonoBehaviour
{
    public void irAjuegoDirecciones() {
        SceneManager.LoadScene(4);


    }

    public void irAMenu()
    {
        SceneManager.LoadScene(2);


    }

    public void irAsubmenu()
    {
        SceneManager.LoadScene(3);


    }

    public void irAInicios()
    {
        SceneManager.LoadScene(0);


    }


    public void irAVocabulary()
    {
        SceneManager.LoadScene(5);


    }

    public void irAregistro()
    {
        SceneManager.LoadScene(1);


    }
}
