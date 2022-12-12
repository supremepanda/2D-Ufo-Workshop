using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Scripts.UI.Buttons.Base
{
    public abstract class UIButtonBase : MonoBehaviour
    {
        [SerializeField] private Button _button;

        private void Start()
        {
            _button.onClick.AddListener(OnClickActions());
        }

        protected abstract UnityAction OnClickActions();
    }
}