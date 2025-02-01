using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public GameObject ObjPuntos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ObjPuntos.GetComponent<puntos>().puntoss += 1;
            Destroy(gameObject);
        }


    }
}
