using UnityEngine;

namespace GMPR2512.Lesson05
{
    public class Bumper : MonoBehaviour
    {
        void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.collider.CompareTag("Ball")){
                Debug.Log($"A game object with the tag {collision.collider.tag} just hit me");
            }
        }
    }
}
