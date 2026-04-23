using System.Collections;
using UnityEngine;

namespace GMPR2512.Lesson06
{
    public class DeathZone : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private Plunger _plunger;
        [SerializeField] private Flipper _leftFlipper, _rightFlipper;

        void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.gameObject.CompareTag("Ball"))
            {
                StartCoroutine(RespawnBall(collider.gameObject));
            }
        }

        private IEnumerator RespawnBall(GameObject ball)
        {
            // Disable plunger and flippers
            _plunger.DisablePlunger();
            _leftFlipper.DisableFlipper();
            _rightFlipper.DisableFlipper();

            // Delay to re-enable plunger and flippers
            // Set to two seconds to give time to test flippers/plunger before being re-enabled
            yield return new WaitForSeconds(2);

            Rigidbody2D BallRB = ball.GetComponent<Rigidbody2D>();

            BallRB.linearVelocity = Vector2.zero;
            BallRB.angularVelocity = 0;

            ball.transform.position = _spawnPoint.position;

            // After delay, re-enable flippers and plunger
            _plunger.EnablePlunger();
            _leftFlipper.EnableFlipper();
            _rightFlipper.EnableFlipper();
        }
    }
}
