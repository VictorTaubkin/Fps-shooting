using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    float speed ;
    float jump;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        jump = 10;
    }

    // Update is called once per frame
   void Update()
    {
          if (Input.GetButtonDown("Jump"))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            //         rb.velocity = Vector2.up * jump;
            rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }
        else
        {
            float offset = Input.GetAxis("Horizontal");
            transform.position = new Vector3(transform.position.x + offset * speed * Time.deltaTime, 0, 0);

        }
    }

}
