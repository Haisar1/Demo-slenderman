using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Casa : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            string levelN = SceneManager.GetActiveScene().name;
            if (levelN == "lvl2")
            {
                SceneManager.LoadScene("menu2");
            }
            else if(levelN == "lvl1") { 
                SceneManager.LoadScene("menu1");
            }
            else if(levelN == "lvl3")
            {
                SceneManager.LoadScene("menu3");
            }
        }
    }
}
