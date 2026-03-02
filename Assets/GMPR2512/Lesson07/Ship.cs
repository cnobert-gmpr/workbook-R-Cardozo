using Codice.Client.BaseCommands.Merge.Restorer.Finder;
using Codice.Client.Common.GameUI;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GMPR2512.Lesson07
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] private float _movementSpeed = 2, _rotationSpeed = 500;
        private InputAction _moveAction, _rotationAction;

        void Awake()
        {
            _moveAction = InputSystem.actions.FindAction("SpaceInvaders/Move");
            _rotationAction = InputSystem.actions.FindAction("SpaceInvaders/Move");
        }

        void Update()
        {
            Vector2 moveDirection = new Vector2(_moveAction.ReadValue<Vector2>().x, 0);
            Vector2 translation = moveDirection.normalized * _movementSpeed * Time.deltaTime;
            transform.Translate(translation, Space.Self);

            float rotationInput = _rotationAction.ReadValue<Vector2>().x;
            float rotationAmount = rotationInput * _rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward, -rotationAmount);
        }
    }
}
