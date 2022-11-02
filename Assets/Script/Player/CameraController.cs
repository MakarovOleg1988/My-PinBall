using System;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

namespace MyPinBall
{
    public class CameraController : MonoBehaviour
    {
        public Camera[] _mainCamera;
        protected NewControls _mainController;

        private void Awake()
        {
            _mainController = new NewControls();
        }

        private void OnEnable()
        {
            _mainController.Enable();
            _mainController.ActionMap.ChangeCamera1.performed += OnChangeCamera1;
            _mainController.ActionMap.ChangeCamera2.performed += OnChangeCamera2;
        }

        private void OnChangeCamera1(CallbackContext context)
        {
            _mainCamera[0].enabled = true;
            _mainCamera[1].enabled = false;
        }

        private void OnChangeCamera2(CallbackContext context)
        {
            _mainCamera[0].enabled = false;
            _mainCamera[1].enabled = true;
        }
    }
}
