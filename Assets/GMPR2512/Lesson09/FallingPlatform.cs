using UnityEngine;

namespace GMPR2512.Lesson09
{
    public class FallingPlatform : MonoBehaviour
    {
        private Renderer _renderer;
        private Rigidbody2D _rb2D;

        void Awake()
        {
            _renderer = GetComponent<Renderer>();
            _rb2D = GetComponent<Rigidbody2D>();
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            _renderer.material.color = Color.crimson;

            
        }
    }
}
