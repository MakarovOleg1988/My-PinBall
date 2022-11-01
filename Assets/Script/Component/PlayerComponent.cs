
using UnityEngine;

namespace MyPinBall
{
    public class PlayerComponent : MonoBehaviour
    {

        protected NewControls _Controller;
        public Rigidbody _rb;
        public Transform transformFirePoint;
        public GameObject _ball;

        [SerializeField, Range(1, 10)] protected float _speedMovement;

        public float GetMovement() => _speedMovement;

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
        }
    }
}
