using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MyPinBall
{
    public abstract class BlockComponent : MonoBehaviour
    {
        [SerializeField] Material[] _colors;

        protected float _score = 0;
        public Text _scoreText;
        protected bool _FirstClick = false;

        public List<Color> _ColorBlock = new List<Color>(2);
    }
}
