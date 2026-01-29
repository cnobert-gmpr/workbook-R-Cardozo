using System.Collections;
using UnityEngine;

namespace GMPR2512.Lesson05
{
    public class DeathZone : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPoint;
        void OnTriggerEnter2D(Collider2D collider)
        {
            // Runs only if game object has the tag 'Ball'
            if (collider.gameObject.CompareTag("Ball"))
            {
                StartCoroutine(RespawnBall(collider.gameObject));
            }
        }

        private IEnumerator RespawnBall(GameObject ball)
        {
            yield return new WaitForSeconds(2);
            Rigidbody2D BallRB = ball.GetComponent<Rigidbody2D>();

            // Resets velocity to ensure the game won't crash due to velocity of ball moving too fast
            BallRB.linearVelocity = Vector2.zero;
            BallRB.angularVelocity = 0;

            // Respawns ball to preset spawnpoint
            ball.transform.position = _spawnPoint.position;
        }
    }
}
