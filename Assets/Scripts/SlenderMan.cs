using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class SlenderMan : MonoBehaviour
{
    private Transform objetivo;
    private NavMeshAgent agente;
    private GameManager gameManager;

    private void Awake()
    {
        objetivo = GameObject.FindGameObjectWithTag("Player").transform;
        agente = GetComponent<NavMeshAgent>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Start()
    {
        StartCoroutine(tiempoDestruccion());
    }

    private void Update()
    {
        agente.SetDestination(objetivo.position);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("menu4");
        }
    }

    private IEnumerator tiempoDestruccion()
    {
        for (int i = 0; i < 25; i++)
        {
            yield return new WaitForSeconds(1);
        }
        gameManager.CrearNuevoSlender();
        Destroy(this.gameObject);
    }

}
