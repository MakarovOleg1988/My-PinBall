using UnityEngine;

namespace MyPinBall
{
    public class Player2Controller : PlayerComponent
    {
        private void Awake()
        {
            _Controller = new NewControls();
        }

        private void OnEnable()
        {
            _Controller.Enable();
        }

        private void Update()
        {
            OnMovement();
        }

        private void OnMovement()
        {
            var _direction = _Controller.ActionMap.MovementPlayer2.ReadValue<Vector2>();
            var _velocity = new Vector3(_direction.x, 0f, _direction.y);
            transform.position += _velocity * GetMovement() * Time.deltaTime;
        }
    }
}
