using UnityEngine;

namespace Game.Scripts.Managers.FinishConditionManager.Base
{
    public abstract class FinishConditionChecker : MonoBehaviour
    {
        protected abstract void CheckFinishConditions();
        protected abstract void OnFinishConditionsMet();
    }
}