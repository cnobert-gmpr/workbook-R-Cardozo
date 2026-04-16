using UnityEngine;

namespace GMPR2512.Lesson09
{
    public class Shooter : MonoBehaviour
    {
        void Update()
        {
            float rotationInput = 0;

            if(Input.GetKey(KeyCode.Comma))
                rotationInput = 1;
            else if(Input.GetKey(KeyCode.Period))
                rotationInput = -1;
            
            transform.parent.Rotate(new Vector3(0, 0, rotationInput));
        }
    }
}
