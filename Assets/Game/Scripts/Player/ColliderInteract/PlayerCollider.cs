using Game.Scripts.Player.ColliderInteract.Interface;
using UnityEngine;

namespace Game.Scripts.Player.ColliderInteract
{
    public class PlayerCollider : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            var rb = other.attachedRigidbody;
            if (rb == null)
                return;
            rb.TryGetComponent(out ICollidable collidable);
            collidable?.Interact();
        }
    }
}