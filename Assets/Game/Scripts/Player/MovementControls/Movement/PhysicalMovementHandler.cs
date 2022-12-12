using Game.Scripts.Player.MovementControls.Movement.Base;
using UnityEngine;

namespace Game.Scripts.Player.MovementControls.Movement
{
    public class PhysicalMovementHandler : MovementHandler
    {
        [SerializeField] private float _force;
        [SerializeField] private Rigidbody2D _rigidbody2D;
        
        protected override void Move(Vector2 direction)
        {
            var forceVector = direction * (_force * Time.deltaTime);
            _rigidbody2D.AddForce(forceVector);
        }
    }
}