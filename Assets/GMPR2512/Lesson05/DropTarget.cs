using UnityEngine;

namespace GMPR2512.Lesson05
{
    public class DropTarget : MonoBehaviour
    {
        [SerializeField] private Color _hitColour = Color.navyBlue;
        [SerializeField] private float _hideDelay = 0.1f, _resetDelay = 2f;
        private bool _isDown = false;
        private SpriteRenderer _renderer;
        private Color _originalColour;
    }
}
