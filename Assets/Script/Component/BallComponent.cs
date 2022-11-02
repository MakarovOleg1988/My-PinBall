using UnityEngine;

namespace MyPinBall
{
    public class BallComponent : MonoBehaviour
    {
        [SerializeField] protected Rigidbody _rbBall;
        protected Vector3 _lastVelocity;
        [SerializeField, Range(0.1f, 2f)] protected float _speedBall;

        void Start()
        {
            _rbBall = GetComponent<Rigidbody>();
        }
    }
}
