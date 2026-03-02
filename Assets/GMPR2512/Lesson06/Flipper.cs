using UnityEngine;

namespace GMPR2512.Lesson06
{
    public class Flipper : MonoBehaviour
    {
            private HingeJoint2D _joint2D;
            private bool _enabled = true;

            void Awake()
            {
                _joint2D = GetComponent<HingeJoint2D>();
            }

            public void EnableFlipper() => _enabled = true;
            public void DisableFlipper() => _enabled = false;

            void Update()
            {
                if (!_enabled)
                {
                    _joint2D.useMotor = false;
                    return;
                }

                if (_joint2D.CompareTag("LeftFlipper"))
                {
                    _joint2D.useMotor = Input.GetKey(KeyCode.LeftShift);
                }

                if (_joint2D.CompareTag("RightFlipper"))
                {
                    _joint2D.useMotor = Input.GetKey(KeyCode.RightShift);
                }
            }
    }
}
