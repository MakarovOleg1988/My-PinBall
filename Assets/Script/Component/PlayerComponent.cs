using UnityEngine;
using UnityEngine.UI;

namespace MyPinBall
{
    public class PlayerComponent : MonoBehaviour
    {
        public static PlayerComponent instance;

        protected NewControls _Controller;
        public Rigidbody _rb;
        public Transform transformFirePoint;
        public GameObject _ball;
        public Text _HealthText;

        [SerializeField, Range(1, 10)] protected float _speedMovement;
        [SerializeField, Range(1, 5)] public int _HealthPlayer;

        public float GetMovement() => _speedMovement;

        private void Start()
        {
            instance = this;
            _rb = GetComponent<Rigidbody>();
        }
    }
}
