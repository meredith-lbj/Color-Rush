using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player_collisions : MonoBehaviour
{
    Material player_mat;
    Color yellow_c = new Color(1.0f, 1.0f, 0.0f, 1.0f);

    private void Start()
    {
        player_mat = GetComponent<Renderer>().material;
    }

    void OnCollisionEnter(Collision obs)
    {
        if (obs.gameObject.tag == "Obstacles") {
            //Destroy(gameObject);
            //Animation des particules
            Debug.Log("Over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //Application.Quit();
        }
        if (obs.gameObject.tag == "Points") {
            if (obs.gameObject.GetComponent<Renderer>().material.color == player_mat.color) {
                //Debug.Log("Same color");
                Destroy(obs.gameObject);
            }
            else if (complex_color(obs, player_mat)) {
                //Debug.Log("Complex color");
            }
            else {
                //Debug.Log("Different color");
            }
        }
    }

    bool complex_color(Collision obs, Material player_mat)
    {
        if (obs.gameObject.GetComponent<Renderer>().material.color == Color.magenta && player_mat.color == Color.red) {
            //Debug.Log("Mangenta");
            player_mat.color = Color.blue;
            return (true);
        }
        if (obs.gameObject.GetComponent<Renderer>().material.color == Color.magenta && player_mat.color == Color.blue) {
            //Debug.Log("Mangenta");
            player_mat.color = Color.red;
            return (true);
        }
        if (obs.gameObject.GetComponent<Renderer>().material.color == yellow_c && player_mat.color == Color.red) {
            //Debug.Log("Yellow");
            player_mat.color = Color.green;
            return (true);
        }
        if (obs.gameObject.GetComponent<Renderer>().material.color == yellow_c && player_mat.color == Color.green ) {
            //Debug.Log("Yellow");
            player_mat.color = Color.red;
            return (true);
        }
        if (obs.gameObject.GetComponent<Renderer>().material.color == Color.cyan && player_mat.color == Color.blue) {
            //Debug.Log("Cyan");
            player_mat.color = Color.green;
            return (true);
        }
        if (obs.gameObject.GetComponent<Renderer>().material.color == Color.cyan && player_mat.color == Color.green) {
            //Debug.Log("Cyan");
            player_mat.color = Color.blue;
            return (true);
        }
        return (false);
    }
}
