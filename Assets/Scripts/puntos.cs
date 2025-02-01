using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntos : MonoBehaviour
{
    public int puntoss;
    public Text textoPuntos;
    [SerializeField] GameObject casa;
    [SerializeField] GameObject mensaje;
    [SerializeField] GameObject mensaje2;
    void Update()
    {
        textoPuntos.text = "objetos: " + puntoss.ToString();
        if (puntoss == 3)
        {
            casa.SetActive(true);
            mensaje.SetActive(true);
            mensaje2.SetActive(false);
        }
    }


    
}
