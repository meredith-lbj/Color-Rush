using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public GameObject Player;
    public float speed = 500f;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    void Update()
    {
        float dir_x = Input.GetAxisRaw("Horizontal");
        float dir_y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)) {
            //A modifier
        }
        else {
            dir_y = dir_y + 0.5f;
            Player.GetComponent<Rigidbody>().velocity = Vector3.zero;
            rb.velocity = new Vector3(dir_x, rb.velocity.y, dir_y) * speed * Time.fixedDeltaTime;
        }
         
    }
}
