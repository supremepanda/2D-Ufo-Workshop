using Game.Scripts.Managers.GoldManagement.Base;

namespace Game.Scripts.Managers.GoldManagement
{
    public class GoldManagerUfo : GoldManager
    {
        public GoldManagerUfo(int initialGoldAmount) : base()
        {
            _goldAmount = initialGoldAmount;
        }

        public override void AddGold(int amount)
        {
            _goldAmount += amount;
            OnGoldChanged();
        }

        public override void RemoveGold(int amount)
        {
            _goldAmount -= amount;
            OnGoldChanged();
        }

        public override void SetGold(int amount)
        {
            _goldAmount = amount;
            OnGoldChanged();
        }

        public override int GetGold()
        {
            return _goldAmount;
        }
    }
}