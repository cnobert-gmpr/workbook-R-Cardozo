using Codice.Client.BaseCommands.Merge.Restorer.Finder;
using Codice.Client.Common.GameUI;
using Codice.CM.Common.Tree;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GMPR2512.Lesson07
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] private float _movementSpeed = 2, _rotationSpeed = 250, _scaleSpeed = 5;
        [SerializeField] private float _rotationLimit = 45f;
        private InputAction _moveAction, _rotationAction, _scaleAction, _fireAction;

        void Awake()
        {
            _moveAction = InputSystem.actions.FindAction("SpaceInvaders/Move");
            _rotationAction = InputSystem.actions.FindAction("SpaceInvaders/Move");
            _scaleAction = InputSystem.actions.FindAction("SpaceInvaders/Scale");
            _fireAction = InputSystem.actions.FindAction("SpaceInvaders/Jump");
        }

        void Update()
        {
            #region ship movement
            // Moves ship left and right
            Vector2 moveDirection = new Vector2(_moveAction.ReadValue<Vector2>().x, 0);
            Vector2 translation = moveDirection.normalized * _movementSpeed * Time.deltaTime;
            transform.Translate(translation, Space.World);
            #endregion

            #region ship rotation
            // Takes up/down input to rotate ship
            float rotationInput = _rotationAction.ReadValue<Vector2>().normalized.y;
            float rotationAmount = rotationInput * _rotationSpeed * Time.deltaTime;
            transform.Rotate(0, 0, rotationAmount);
            
            // Prevents rotation from going past the specified rotation limits
            Vector3 euler = transform.eulerAngles;

            if(euler.z > 180f) euler.z -= 360f;
            euler.z = Mathf.Clamp(euler.z, -_rotationLimit, _rotationLimit);
            transform.eulerAngles = euler;
            #endregion

            #region ship scaling
            // Ship scaling
            float scaleValue = _scaleAction.ReadValue<float>() * _scaleSpeed * Time.deltaTime;
            Vector3 scaleChange = new Vector3(scaleValue, scaleValue, scaleValue);
            transform.localScale += scaleChange;

            Vector3 scale = transform.localScale;
            if(scale.x < 0)
                scale.x = 0;
            if(scale.y < 0)
                scale.y = 0;
            if(scale.z < 0)
                scale.z = 0;
            transform.localScale = scale;
            
            #endregion
        }
    }
}
