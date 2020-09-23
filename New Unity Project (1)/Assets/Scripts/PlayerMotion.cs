using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 4f; 
    }

    // Update is called once per frame
    void Update()
    {
  //      if (Input.GetButtonDown("Horizontal"))
        {
            float offset = Input.GetAxis("Horizontal")*speed * Time.deltaTime;
            transform.position =  new Vector3(transform.position.x + offset, transform.position.y, transform.position.z);
        }
    }
}
