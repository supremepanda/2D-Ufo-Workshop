using Game.Scripts.Managers.LevelCompletionManagement.Base;
using Zenject;

namespace Game.Scripts.Managers.LevelCompletionManagement
{
    public class LevelCompletionManagerInstaller : MonoInstaller<LevelCompletionManagerInstaller>
    {
        public override void InstallBindings()
        {
            // Container.Bind<LevelCompletionManager>().FromInstance(new LevelCompletionManagerUfo()).AsSingle().NonLazy();
        }
    }
}