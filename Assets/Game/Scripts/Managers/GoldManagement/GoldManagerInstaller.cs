using Game.Scripts.Managers.GoldManagement.Base;
using Zenject;

namespace Game.Scripts.Managers.GoldManagement
{
    public class GoldManagerInstaller : MonoInstaller<GoldManagerInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<GoldManager>().FromInstance(new GoldManagerUfo(0)).AsSingle().NonLazy();
        }
    }
}