using System;
using UnityEngine;

namespace Game.Scripts.Player.MovementControls.Input.Base
{
    public abstract class InputHandler : MonoBehaviour
    {
        public event Action<Vector2> InputDirectionChanged;

        protected virtual void Update()
        {
            SendInput(CalculateInput());
        }

        protected abstract Vector2 CalculateInput();

        protected virtual void SendInput(Vector2 input)
        {
            OnInputDirectionChanged(input);
        }

        protected virtual void OnInputDirectionChanged(Vector2 input)
        {
            InputDirectionChanged?.Invoke(input);
        }
    }
}