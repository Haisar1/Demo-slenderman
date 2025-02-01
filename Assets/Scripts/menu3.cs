using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu3 : MonoBehaviour
{
 public void Jugar()
    {
        SceneManager.LoadScene("lvl1");

    }


  public void Salir()
    {
        Application.Quit();

    }
}
