using Game.Scripts.Player.MovementControls.Input.Base;
using Game.Scripts.Player.MovementControls.Movement.Base;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Player
{
    public class PlayerContextInstallers : MonoInstaller<PlayerContextInstallers>
    {
        [SerializeField] private InputHandler _inputHandler;
        [SerializeField] private MovementHandler _movementHandler;
        public override void InstallBindings()
        {
            Container.Bind<InputHandler>().FromInstance(_inputHandler).AsCached().NonLazy();
            Container.Bind<MovementHandler>().FromInstance(_movementHandler).AsCached().NonLazy();
        }
    }
}