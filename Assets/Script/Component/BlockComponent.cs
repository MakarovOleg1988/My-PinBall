using UnityEngine;
using UnityEngine.UI;

namespace MyPinBall
{
    public class BlockComponent : MonoBehaviour
    {
        public static BlockComponent instance;

        [SerializeField] protected Material[] _colors;
        public Text _scoreText;
        public int _score;

        private void Start()
        {
            instance = this;
        }

    }
}
