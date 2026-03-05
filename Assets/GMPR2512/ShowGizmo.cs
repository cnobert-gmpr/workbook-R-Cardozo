using System;
using UnityEngine;

namespace GMPR2512
{
    public class ShowGizmo : MonoBehaviour
    {
        [SerializeField] private Color _gizmoColour = new Color(20f/255f, 20f/255f, 20f/255f, 1f);
        [SerializeField] private float _radius = 0.1f;

        void OnDrawGizmos()
        {
            Gizmos.color = _gizmoColour;

            Gizmos.DrawSphere(transform.position, _radius);
        }
    }
}
