using System;

namespace Game.Scripts.Managers.GoldManagement.Base
{
    public abstract class GoldManager
    {
        public event Action GoldChanged;
        protected int _goldAmount;

        public GoldManager(){}
        
        public abstract void AddGold(int amount);
        public abstract void RemoveGold(int amount);
        public abstract void SetGold(int amount);
        public abstract int GetGold();

        protected virtual void OnGoldChanged()
        {
            GoldChanged?.Invoke();
        }
    }
}