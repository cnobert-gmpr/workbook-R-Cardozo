using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Diagnostics;

namespace GMPR2512.Lesson08
{
    public class Scene00_Button_Handler : MonoBehaviour
    {
        private Scene00_Button_Handler _changeToScene01Button;

        private void OnEnable()
        {
            VisualElement root = GetComponent<>().rootVisualElement;
            _changeToScene01Button = root.Q<Button>("ChangeToScene01Button");

            if(_changeToScene01Button != null)
            {
                _changeToScene01Button.clicked += ChangeToScene01;
            }
        }

        private void OnDisable()
        {
            if(_changeToScene01Button != null)
            {
                _changeToScene01Button.clicked -= ChangeToScene01;
            }
        }

        private void ChangeToScene01()
        {
            Debug.Log("Button Clicked! :)");
            SceneManager.LoadScene(1);
        }
    }
}
