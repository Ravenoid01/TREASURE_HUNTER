using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField]PlayerController playerController;
    [SerializeField] UIManager uiManager;
    [SerializeField] GameObject Puerta;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && playerController.keys >= 1)
        {
            Destroy(Puerta);
            playerController.keys -= 1;
        }
        else
        {
            uiManager.ShowMessage();
        }
    }
}
