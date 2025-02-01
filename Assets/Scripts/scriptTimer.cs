using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class scriptTimer : MonoBehaviour {

    public Text contador;
    private float tiempo = 200f;

	// Use this for initialization
	void Start () {
        contador.text = "limite de tiempo: " + tiempo;

	}
	
	// Update is called once per frame
	void Update () {
        tiempo -= Time.deltaTime;
        contador.text = "limite de tiempo: " + tiempo.ToString("f0");

        if(tiempo <= 0)
        {
            contador.text = "0";
            SceneManager.LoadScene("menu4");
        }
	
	}
}
