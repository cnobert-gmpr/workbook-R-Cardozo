using UnityEngine;

namespace GMPR2512.Lesson07
{
    public class Projectile : MonoBehaviour
    {
        private float _speed = 10, _spinVelocity;
        private Vector2 _direction = Vector2.up;

        void Update()
        {
            transform.Translate(_direction.normalized * _speed * Time.deltaTime, Space.World);
        }
    }
}
