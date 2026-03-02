using Codice.Client.BaseCommands.Merge.Restorer.Finder;
using Codice.Client.Common.GameUI;
using Codice.CM.Common.Tree;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GMPR2512.Lesson07
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] private float _movementSpeed = 2, _rotationSpeed = 250;
        [SerializeField] private float _rotationLimit = 45f;
        private InputAction _moveAction, _rotationAction;

        void Awake()
        {
            _moveAction = InputSystem.actions.FindAction("SpaceInvaders/Move");
            _rotationAction = InputSystem.actions.FindAction("SpaceInvaders/Move");
        }

        void Update()
        {
            // Moves ship left and right
            Vector2 moveDirection = new Vector2(_moveAction.ReadValue<Vector2>().x, 0);
            Vector2 translation = moveDirection.normalized * _movementSpeed * Time.deltaTime;
            transform.Translate(translation, Space.Self);

            // Takes up/down input to rotate ship
            float rotationInput = _rotationAction.ReadValue<Vector2>().y;
            float rotationAmount = rotationInput * _rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward, -rotationAmount);

            // Prevents rotation from going past the specified rotation limits
            Vector3 euler = transform.eulerAngles;

            if(euler.z > 180f) euler.z -= 360f;
            euler.z = Mathf.Clamp(euler.z, -_rotationLimit, _rotationLimit);
            transform.eulerAngles = euler;
        }
    }
}
