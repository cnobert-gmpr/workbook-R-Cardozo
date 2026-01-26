using UnityEngine;

namespace GMPR2512.Lesson05
{
    public class DeathZone : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.gameObject.CompareTag("Ball"))
            {
                Debug.Log("Kapow!");
            }
        }
    }
}
