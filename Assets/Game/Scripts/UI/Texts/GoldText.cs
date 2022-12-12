using Game.Scripts.Managers.GoldManagement.Base;
using Game.Scripts.UI.Texts.Base;
using Zenject;

namespace Game.Scripts.UI.Texts
{
    public class GoldText : UITextBase
    {
        [Inject] private GoldManager _goldManager;

        protected override void Start()
        {
            base.Start();
            _goldManager.GoldChanged += SetText;
        }

        private void OnDestroy()
        {
            _goldManager.GoldChanged -= SetText;
        }
        
        protected override string GetUpdatedString()
        {
            return _goldManager.GetGold().ToString();
        }
    }
}