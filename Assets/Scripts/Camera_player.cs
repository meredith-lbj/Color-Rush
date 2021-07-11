using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_player : MonoBehaviour
{
    public GameObject Player;
    private Vector3 camera_offset;

    void Start()
    {
        camera_offset = transform.position - Player.transform.position;
    }

    void Update()
    {
        transform.position = Player.transform.position + camera_offset;
    }
}
