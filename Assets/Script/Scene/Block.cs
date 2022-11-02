using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyPinBall
{
    public class Block : BlockComponent
    {
        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.GetComponent<SphereCollider>() != null) StartCoroutine(DestroyBlock());
        }

        public IEnumerator DestroyBlock()
        {
            _score += 1;
            _scoreText.text = _score.ToString();
            yield return new WaitForSeconds(0.01f);
            Destroy(gameObject);
            yield return null;
        }
    }
}
