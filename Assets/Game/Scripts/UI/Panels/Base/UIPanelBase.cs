using UnityEngine;

namespace Game.Scripts.UI.Panels.Base
{
    public abstract class UIPanelBase : MonoBehaviour
    {
        public abstract void Activate(bool flag);

        protected virtual void SetActive()
        {
            Activate(true);
        }
        
        protected virtual void SetInactive()
        {
            Activate(false);
        }
    }
}