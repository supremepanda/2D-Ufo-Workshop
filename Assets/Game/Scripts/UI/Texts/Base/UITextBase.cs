using TMPro;
using UnityEngine;

namespace Game.Scripts.UI.Texts.Base
{
    public abstract class UITextBase : MonoBehaviour
    {
        [SerializeField] private string _prefix;
        [SerializeField] private string _suffix;
        [SerializeField] private TMP_Text _text;

        protected virtual void Start()
        {
            SetText();
        }

        protected abstract string GetUpdatedString();

        protected virtual void SetText()
        {
            _text.text = $"{_prefix}{GetUpdatedString()}{_suffix}";
        }
    }
}