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
            _joint2D.useMotor = Input.GetKey(KeyCode.RightShift);
        }
    }
}
