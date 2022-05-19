using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sight : MonoBehaviour
{

    EnemyController controller;
    [SerializeField]PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponentInParent<EnemyController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && player.movementSpeed >2)
        {
            controller.OnSight(other.transform);
        }
    }
}
