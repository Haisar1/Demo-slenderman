using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicapersonaje : MonoBehaviour
{
    public float velocidadMovimiento = 3.0f;
    public float velocidadRotacion = 200.0f;
  

    void Awake()
    {
      //  puntuacion = 0;
    }
    //private Animator anim;
    public float x, y;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);



    }




    
}