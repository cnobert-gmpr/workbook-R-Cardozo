using System.Collections;
using UnityEngine;

namespace GMPR2512.Lesson05
{
    public class DeathZone : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPoint;
        void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.gameObject.CompareTag("Ball"))
            {
                StartCoroutine(RespawnBall(collider.gameObject));
            }
        }

        private IEnumerator RespawnBall(GameObject ball)
        {
            yield return new WaitForSeconds(2);

            Debug.Log("It's been 2 seconds since the ball left gameplay");

            Destroy(ball);
        }
    }
}
