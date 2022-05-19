using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{

    public float movementSpeed = 4.0f;
    public int keys;
    public int swords;

    void Start()
    {
        keys = 0;
        swords = 0;
    }

    void Update()
    {

        Rigidbody rigidbody = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.LeftShift))
        {
            movementSpeed = 2f;
        }
        else
        {
            movementSpeed = 4f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rigidbody.position += Vector3.back * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rigidbody.position += Vector3.left * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody.position += Vector3.right * Time.deltaTime * movementSpeed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && swords <= 0)
        {
            SceneManager.LoadScene("Rave");
        }
        else if(collision.gameObject.CompareTag("Enemy") && swords >= 1)
        {
            Destroy(collision.gameObject);
            swords -= 1;
        }
    }
}