using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uı : MonoBehaviour
{
    public void cikis()
    {
        Application.Quit();
    }

    public void OyunaGir()
    {
        SceneManager.LoadScene(1);
    }

    public void MenuDon()
    {
        SceneManager.LoadScene(0);
    }
}
