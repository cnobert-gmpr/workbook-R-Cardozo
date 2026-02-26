using System.Collections;
using UnityEngine;

namespace GMPR2512.Lesson06
{
    public class DeathZone : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private Bumper _bumper1Script, _bumper2Script;

        void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.gameObject.CompareTag("Ball"))
            {
                StartCoroutine(RespawnBall(collider.gameObject));
            }
        }

        private IEnumerator RespawnBall(GameObject ball)
        {
            yield return new WaitForSeconds(1);
            Rigidbody2D BallRB = ball.GetComponent<Rigidbody2D>();

            BallRB.linearVelocity = Vector2.zero;
            BallRB.angularVelocity = 0;

            ball.transform.position = _spawnPoint.position;
        }
    }
}
