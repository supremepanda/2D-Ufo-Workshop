using Game.Scripts.Managers.FinishConditionManager.Base;
using Game.Scripts.Managers.GoldManagement.Base;
using Game.Scripts.Managers.LevelCompletionManagement.Base;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Managers.FinishConditionManager
{
    public class GoldFinishConditionChecker : FinishConditionChecker
    {
        [Inject] private GoldManager _goldManager;
        [Inject] private LevelCompletionManager _levelCompletionManager;
        [SerializeField] private int _targetGoldCount;
        private bool _isFinished;
        
        private void OnEnable()
        {
            _goldManager.GoldChanged += CheckFinishConditions;
        }

        private void OnDisable()
        {

            _goldManager.GoldChanged -= CheckFinishConditions;
        }

        protected override void CheckFinishConditions()
        {
            if(_goldManager.GetGold() >= _targetGoldCount)
                OnFinishConditionsMet();
        }

        protected override void OnFinishConditionsMet()
        {
            if (_isFinished)
                return;
            _isFinished = true;
            _levelCompletionManager.OnLevelCompleted();
        }
    }
}