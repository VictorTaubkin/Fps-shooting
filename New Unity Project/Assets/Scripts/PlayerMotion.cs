using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    float horizontal_speed;
  //  Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        horizontal_speed = 5f;
  //      rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position= new Vector3(transform.position.x+
            horizontal_speed * Input.GetAxis("Horizontal")*Time.deltaTime, transform.position.y, 0);
    }
}
