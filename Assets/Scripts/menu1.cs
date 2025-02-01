using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu1 : MonoBehaviour
{
 public void Jugar()
    {
        SceneManager.LoadScene("lvl2");

    }


  public void Salir()
    {
        Application.Quit();

    }
}
