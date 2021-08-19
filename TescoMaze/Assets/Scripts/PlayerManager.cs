using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    CameraManager cameraManager;
    PlayerMotion playerMotion;

    private void Awake()
    {

        inputManager = GetComponent<InputManager>();
        playerMotion = GetComponent<PlayerMotion>();
        cameraManager = FindObjectOfType<CameraManager>();
        instance = this;
    }

    private void Update()
    {
        inputManager.HandleAllInputs();

    }


    private void FixedUpdate()
    {

        playerMotion.HandleAllMovement();

    }

    private void LateUpdate()
    {

        cameraManager.HandleALLCameraMovement();

    }

    public static PlayerManager instance;

    public GameObject player;



}
