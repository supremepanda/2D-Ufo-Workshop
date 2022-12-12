using Game.Scripts.Player.MovementControls.Input.Base;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Player.MovementControls.Movement.Base
{
    public abstract class MovementHandler : MonoBehaviour
    {
        [Inject] private InputHandler _inputHandler;

        private void Start()
        {
            _inputHandler.InputDirectionChanged += Move;
        }

        private void OnDestroy()
        {
            _inputHandler.InputDirectionChanged -= Move;
        }

        protected abstract void Move(Vector2 direction);
        
    }
}