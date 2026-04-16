using UnityEngine;

namespace GMPR2512.Lesson09
{
    public class Shooter : MonoBehaviour
    {
        void Update()
        {
            float rotationInput = 0;

            if(Input.GetKey(KeyCode.Comma))
                rotationInput = 125;
            else if(Input.GetKey(KeyCode.Period))
                rotationInput = -125;
            
            rotationInput *= Time.deltaTime;
            transform.parent.Rotate(new Vector3(0, 0, rotationInput));

            int layerMask = LayerMask.GetMask("Ground", "Enemy");
        }

        /**
        void OnDrawGizmo()
        {
            Gizmos.color = Color.yellowNice;
            Gizmos.DrawRay(transform.position, transform.right * 10);
        }
        **/
    }
}
