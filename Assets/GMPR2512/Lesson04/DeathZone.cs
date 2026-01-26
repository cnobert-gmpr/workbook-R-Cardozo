using UnityEngine;

namespace Lesson04
{
    public class DeathZone : MonoBehaviour
    {
        [SerializeField] private int _year = 1000;
        private float _seconds;
        void Awake()
        {
            _year += 1026;
            Debug.Log($"It's the year {_year}!");
        }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        
        void Start()
        {
            Debug.Log($"It's the year {_year}!");
            _year++;
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        void OnTriggerEnter2D(Collider2D collider)
        {
            Debug.Log("Collision >:D");
            Destroy(collider.gameObject);
        }
    }
}
