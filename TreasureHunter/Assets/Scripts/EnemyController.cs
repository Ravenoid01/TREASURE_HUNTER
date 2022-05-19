using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    [SerializeField] float speed;
    private int state;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        state = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(state == 1)
        {
            Chase();
            transform.position += transform.forward * Time.deltaTime * speed;
            Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * 10 * Time.deltaTime);
        }
    }
  
    public void Chase()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if(distance <= 2f)
        {

        }
    }
    public void OnSight(Transform other)
    {
        target = other.transform;
        state = 1;
    }
}
