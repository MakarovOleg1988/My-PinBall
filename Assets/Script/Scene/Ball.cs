using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyPinBall
{
    public class Ball : BallComponent
    {

        private void Update()
        {
            _lastVelocity = _rbBall.velocity;
        }
        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.GetComponent<Obstacles>() == null) return;

            var _direction = Vector3.Reflect(_lastVelocity.normalized, collision.contacts[0].normal);
            _rbBall.velocity = _direction * Mathf.Max(0f, _speedBall);

            _rbBall.useGravity = false;
        }
    }
}
