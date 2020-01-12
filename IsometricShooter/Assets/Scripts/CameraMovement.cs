using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private GameObject mainCamera;
    private GameObject player;
    private Vector3 playerPos;
    private Vector3 mainCameraPos;
    private Vector3 cameraCenter = new Vector3(-35, 50, -35);

    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
        mainCameraPos = playerPos + cameraCenter;
        mainCamera.transform.position = mainCameraPos;
    }
}
