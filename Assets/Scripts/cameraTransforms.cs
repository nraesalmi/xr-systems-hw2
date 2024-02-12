using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;


public class cameraTransform : MonoBehaviour
{
    public Transform roomPosition;
    public Transform breakOutPosition;

    [SerializeField]
    private InputActionReference breakOutAction;

    [SerializeField]
    private InputActionReference rCameraAction;

    [SerializeField]
    private InputActionReference lCameraAction;

    private bool inside = true;

    void Start()
    {
            breakOutAction.action.Enable();
            breakOutAction.action.performed += (ctx) =>
            {
                TogglePosition();
            };
            
            rCameraAction.action.Enable();
            rCameraAction.action.performed += (ctx) =>
            {
                RotateView(-30f);
            };

            lCameraAction.action.Enable();
            lCameraAction.action.performed += (ctx) =>
            {
                RotateView(30f);
            };
    }

    void TogglePosition()
    {
        inside = !inside;

        if (inside)
        {
            transform.position = roomPosition.position;
        }
        else
        {
            transform.position = breakOutPosition.position;
        }
    }

    void RotateView(float degrees)
    {
        transform.Rotate(Vector3.up, degrees);
    }
}
