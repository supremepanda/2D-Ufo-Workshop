using Game.Scripts.Player.ColliderInteract.Interface;
using UnityEngine;

namespace Game.Scripts.Collectables.Base
{
    public abstract class CollectableBase : MonoBehaviour, ICollidable
    {
        private bool _isCollected;

        public void Interact()
        {
            if(_isCollected) 
                return;
            _isCollected = true;
            OnCollected();
        }

        protected abstract void OnCollected();
    }
}