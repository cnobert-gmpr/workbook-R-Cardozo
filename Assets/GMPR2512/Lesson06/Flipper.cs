using UnityEngine;

namespace GMPR2512.Lesson06
{
    public class Flipper : MonoBehaviour
    {
        private HingeJoint2D _joint2D;

        void Awake()
        {
            _joint2D = GetComponent<HingeJoint2D>();
        }
        void Update()
        {
            if (_joint2D.CompareTag("Left"))
            {
                _joint2D.useMotor = Input.GetKey(KeyCode.LeftShift);
            }

            if (_joint2D.CompareTag("Right"))
            {
                _joint2D.useMotor = Input.GetKey(KeyCode.RightShift);
            }
        }
    }
}
