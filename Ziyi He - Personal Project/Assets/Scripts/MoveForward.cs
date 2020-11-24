using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    //objects will move forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    //objects will destory in this range
        if (transform.position.z > -58f || transform.position.z < -100f)
            Destroy(gameObject);
    }

    public void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

    }
}
