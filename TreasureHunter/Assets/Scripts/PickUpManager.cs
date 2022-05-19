using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpManager : MonoBehaviour
{
    [SerializeField]PlayerController playerController;
    [SerializeField]GameObject PickUp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && PickUp.CompareTag("Key"))
        {
            playerController.keys += 1;
            PickUp.SetActive(false);
        }
        if (other.CompareTag("Player") && PickUp.CompareTag("Sword"))
        {
            playerController.swords += 1;
            PickUp.SetActive(false);
        }
    }
}
