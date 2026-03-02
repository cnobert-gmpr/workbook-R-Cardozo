using UnityEngine;

namespace GMPR2512.Lesson06
{
    public class Plunger : MonoBehaviour
    {
        [SerializeField] private float _launchForce = 750f;
        [SerializeField] private Transform _holdBall;
        [SerializeField] private Rigidbody2D _ballRB;
        private bool ballLoaded = true, _enabled = true;

        void Update()
        {
            if(!_enabled) return;

            if(ballLoaded && _ballRB != null)
            {
                if (!Input.GetKeyDown(KeyCode.Space) && ballLoaded)
                {
                    _ballRB.position = _holdBall.position;
                    _ballRB.linearVelocity = Vector2.zero;
                    _ballRB.angularVelocity = 0;
                }
            }

            if(Input.GetKeyDown(KeyCode.Space))
            {
                // Applies upward force when space bar is pressed
                _ballRB.AddForce(Vector2.up * _launchForce, ForceMode2D.Impulse);
                ballLoaded = false;

            }
        }

        public void EnablePlunger()
        {
            _enabled = true;
            ballLoaded = true;
        }

        public void DisablePlunger() => _enabled = false;
    }
}
