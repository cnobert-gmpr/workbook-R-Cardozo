using Codice.Client.Common.GameUI;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GMPR2512.Lesson07
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] private float _movementSpeed = 2f;
        private InputAction _moveActions;

        void Update()
        {

            transform.Translate(new Vector3(-1 * Time.deltaTime, Time.deltaTime, 0));
        }
    }
}
