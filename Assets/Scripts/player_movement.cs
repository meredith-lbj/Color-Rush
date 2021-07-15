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

        if (Input.touchCount > 0) {
            Touch firstTouch = Input.GetTouch(0);

            if (firstTouch.phase == TouchPhase.Moved) {
                if (firstTouch.position.x > (Screen.width / 2)) {
                    dir_x = dir_x + 0.5f;
                    Player.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    rb.velocity = new Vector3(dir_x, rb.velocity.y, dir_y) * speed * Time.fixedDeltaTime;
                }
                else if (firstTouch.position.x < (Screen.width / 2)) {
                    dir_x = dir_x - 0.5f;
                    Player.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    rb.velocity = new Vector3(dir_x, rb.velocity.y, dir_y) * speed * Time.fixedDeltaTime;
                }
                
            }
        }
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
