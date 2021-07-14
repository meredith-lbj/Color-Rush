using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Player_collisions : MonoBehaviour
{
    public Text scoreText;
    uint score = 0;
    Material player_mat;
    Color yellow_c = new Color(1.0f, 1.0f, 0.0f, 1.0f);

    private void Start()
    {
        player_mat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

    void OnCollisionEnter(Collision obs)
    {
        if (obs.gameObject.tag == "Obstacles") {
            //Destroy(gameObject);
            //Animation des particules
            Debug.Log("Over");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //Application.Quit();
        }
        if (obs.gameObject.tag == "Points") {
            if (obs.gameObject.GetComponent<Renderer>().material.color == player_mat.color) {
                score++;
                Destroy(obs.gameObject);
            }
            else if (complex_color(obs, player_mat)) {
                score += 4;
            }
            else {
            }
        }
    }

    bool complex_color(Collision obs, Material player_mat)
    {
        if (obs.gameObject.GetComponent<Renderer>().material.color == Color.magenta && player_mat.color == Color.red) {
            player_mat.color = Color.blue;
            Destroy(obs.gameObject);
            return (true);
        }
        if (obs.gameObject.GetComponent<Renderer>().material.color == Color.magenta && player_mat.color == Color.blue) {
            player_mat.color = Color.red;
            Destroy(obs.gameObject);
            return (true);
        }
        if (obs.gameObject.GetComponent<Renderer>().material.color == yellow_c && player_mat.color == Color.red) {
            player_mat.color = Color.green;
            Destroy(obs.gameObject);
            return (true);
        }
        if (obs.gameObject.GetComponent<Renderer>().material.color == yellow_c && player_mat.color == Color.green ) {
            player_mat.color = Color.red;
            Destroy(obs.gameObject);
            return (true);
        }
        if (obs.gameObject.GetComponent<Renderer>().material.color == Color.cyan && player_mat.color == Color.blue) {
            player_mat.color = Color.green;
            Destroy(obs.gameObject);
            return (true);
        }
        if (obs.gameObject.GetComponent<Renderer>().material.color == Color.cyan && player_mat.color == Color.green) {
            player_mat.color = Color.blue;
            Destroy(obs.gameObject);
            return (true);
        }
        return (false);
    }
}
