using System;
using UnityEngine;

namespace GMPR2512.Lesson09
{
    public class Shooter : MonoBehaviour
    {
        private Transform _lastObjectHit = null;
        [SerializeField] private float _laserLength = 8f;
        private LineRenderer _laserLine;

        void Update()
        {
            float rotationInput = 0;

            if(Input.GetKey(KeyCode.Comma))
                rotationInput = 125;
            else if(Input.GetKey(KeyCode.Period))
                rotationInput = -125;
            
            rotationInput *= Time.deltaTime;
            transform.parent.Rotate(new Vector3(0, 0, rotationInput));

            int layerMask = LayerMask.GetMask("Ground", "Enemy");
            RaycastHit2D rh2d = Physics2D.Raycast(transform.position, transform.right, Mathf.Infinity, layerMask);

            /* Raycasting for lasers
            if(rh2d.transform != null)
            {
                rh2d.transform.gameObject.GetComponent<Renderer>().material.color = Color.green;

                if(_lastObjectHit != null && rh2d.transform != _lastObjectHit)
                    _lastObjectHit.gameObject.GetComponent<Renderer>().material.color = Color.white;

                _lastObjectHit = rh2d.transform;
            }
            else if(_lastObjectHit != null)
                _lastObjectHit.gameObject.GetComponent<Renderer>().material.color = Color.white;
            */
        }

        /* Draw Gizmo
        void OnDrawGizmo()
        {
            Gizmos.color = Color.yellowNice;
            Gizmos.DrawRay(transform.position, transform.right * 10);
        }
        */
    }
}
