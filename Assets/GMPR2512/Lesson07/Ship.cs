using Codice.Client.BaseCommands.Merge.Restorer.Finder;
using Codice.Client.Common.GameUI;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GMPR2512.Lesson07
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] private float _movementSpeed = 2f;
        private InputAction _moveAction;

        void Awake()
        {
            _moveAction = InputSystem.actions.FindAction("SpaceInvaders/Move");
        }

        void Update()
        {
            Vector2 moveDirection = _moveAction.ReadValue<Vector2>();
            Vector2 translation = moveDirection.normalized * _movementSpeed * Time.deltaTime;
            transform.Translate(translation, Space.Self);
        }
    }
}
