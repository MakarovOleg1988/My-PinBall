using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyPinBall
{
    public class Block : BlockComponent
    {
        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.GetComponent<SphereCollider>() == null) return;
            _score++;
            _scoreText.text = _score.ToString();
            Destroy(this.gameObject);
        }
    }
}
