using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu2 : MonoBehaviour
{
 public void Jugar()
    {
        SceneManager.LoadScene("lvl3");

    }


  public void Salir()
    {
        Application.Quit();

    }
}
