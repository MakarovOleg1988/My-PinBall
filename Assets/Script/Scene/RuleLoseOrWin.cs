using UnityEngine;

namespace MyPinBall
{
    public class RuleLoseOrWin : MonoBehaviour
    {
        [SerializeField] private bool IsDamage;

        private void OnTriggerEnter(Collider other)
        {
            if (IsDamage == true)
            {
                TakeDamage(1);
                Destroy(other.gameObject);
            }
        }

        void TakeDamage(int damage)
        {
            PlayerComponent.instance._HealthPlayer -= damage;
            PlayerComponent.instance._HealthText.text = PlayerComponent.instance._HealthPlayer.ToString();
        }

        public void LoseGame()
        {
            if (PlayerComponent.instance._HealthPlayer <= 0)
            {
                Debug.Log("¬€ œ–Œ»√–¿À»");
                Time.timeScale = 0f;
            }
        }

        public void WinGame()
        {
            if (BlockComponent.instance._score >= 5)
            {
                Debug.Log("¬€ ¬€»√–¿À»");
                Time.timeScale = 0f;
            }
        }
    }
}
