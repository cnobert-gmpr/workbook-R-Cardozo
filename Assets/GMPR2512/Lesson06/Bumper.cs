using System.Collections;
using UnityEngine;

namespace GMPR2512.Lesson06
{
    
public class Bumper : MonoBehaviour
{
    [SerializeField] private float _bumperForce = 20, _litFor = 0.3f;
    [SerializeField] private Color _litColour = new Color(124f/255f, 199f/255f, 228f/255f, 1f);
    private bool _isLit = false;
    private Color _ogColour;
    private SpriteRenderer _renderer;
    private Collider2D _collider;

    void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _ogColour = _renderer.color;
        _collider = GetComponent<Collider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ball"))
        {
            if(collision.rigidbody != null)
            {
                #region add force to bumper

                Vector2 normal = Vector2.zero;
                if(collision.contactCount > 0)
                {
                    ContactPoint2D contact = collision.GetContact(0);
                    normal = contact.normal;
                }

                if(normal == Vector2.zero)
                {
                    Vector2 direction = (collision.rigidbody.position - (Vector2)transform.position).normalized;
                    normal = direction;
                }

                normal *= -1;

                Vector2 impulse = normal * _bumperForce;

                collision.rigidbody.AddForce(impulse, ForceMode2D.Impulse);

                #endregion

                #region change ball colour when hit

                if (!_isLit)
                {
                    StartCoroutine(LightUp());
                }

                #endregion
            }
        }
    }

    private IEnumerator LightUp()
    {
        _isLit = true;
        _renderer.color = _litColour;

        yield return new WaitForSeconds(_litFor);

        _renderer.color = _ogColour;

        _isLit = false;
    }
}

}
