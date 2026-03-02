using UnityEngine;

namespace GMPR2512.Lesson07
{
    public class Ship : MonoBehaviour
    {
        void Update()
        {
            transform.Translate(new Vector3(2 * Time.deltaTime, 0, 0));
        }
    }
}
