using Game.Scripts.Managers.FinishConditionManager.Base;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Managers.FinishConditionManager
{
    public class FinishConditionCheckerInstaller : MonoInstaller<FinishConditionCheckerInstaller>
    {
        [SerializeField] private FinishConditionChecker _finishConditionChecker;
        public override void InstallBindings()
        {
            Container.Bind<FinishConditionChecker>().FromInstance(_finishConditionChecker).AsSingle().NonLazy();
        }        
    }
}