using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_collisions : MonoBehaviour
{
    Material obs_mat;

    private void Start()
    {
        obs_mat = GetComponent
    }

    void OnCollisionEnter(Collision obs)
    {
        if (obs.gameObject.tag == "Obstacles") {
            //Destroy(gameObject);
            //Animation des particules
        }
        if (obs.gameObject.tag == "Points") {
            if (obs.gameObject.)
        }
    }
}
