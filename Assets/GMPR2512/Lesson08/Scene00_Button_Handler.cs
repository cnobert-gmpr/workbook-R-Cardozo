using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Diagnostics;

namespace GMPR2512.Lesson08
{
    public class Scene00_Button_Handler : MonoBehaviour
    {
        private Button _changeToScene01Button;

        private void OnEnable()
        {
            VisualElement root = GetComponent<UIDocument>().rootVisualElement;
            _changeToScene01Button = root.Q<Button>("PlayButton");

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
            SceneManager.LoadScene(1);
        }
    }
}
