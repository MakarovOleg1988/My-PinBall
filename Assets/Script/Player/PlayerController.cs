using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyPinBall
{
    public class PlayerController : PlayerComponent
    {
        private void Awake()
        {
            _Controller = new NewControls();
        }

        private void OnEnable()
        {
            _Controller.Enable();
            _Controller.ActionMap.CreateBall.performed += _ => CreateBall();
        }

        private void Update()
        {
            OnMovement();
        }

        private void OnMovement()
        {
            var _direction = _Controller.ActionMap.Movement.ReadValue<Vector2>();
            var _velocity = new Vector3(_direction.x, 0f, _direction.y);
            transform.position += _velocity * GetMovement() * Time.deltaTime;
        }

        private void CreateBall()
        {
            Instantiate(_ball, transformFirePoint.position, Quaternion.identity);
        }

    }
}

