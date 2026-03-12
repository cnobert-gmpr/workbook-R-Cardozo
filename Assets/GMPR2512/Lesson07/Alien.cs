using UnityEngine;

namespace GMPR2512.Lesson07
{
    public class Alien : MonoBehaviour
    {
        [SerializeField] private float _projectileSpeed = 5, _projectileSpinVelocity = 2000;
        [SerializeField] private GameObject _projectilePrefab;
        [SerializeField] private int _upperRandomFiringRange;

        void Update()
        {
            int rando = Random.Range(1, _upperRandomFiringRange);
        }
    }
}
