using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OcultarCuarto : MonoBehaviour
{
    [SerializeField] GameObject techo;
    [SerializeField] UIManager uIManager;
    void Start()
    {
        techo.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ApagarPrenderTecho(other);
            uIManager.ApagarMensaje();
        }        

    }
    private void ApagarPrenderTecho(Collider jugador)
    {
        techo.SetActive(false);
        
    }
}
