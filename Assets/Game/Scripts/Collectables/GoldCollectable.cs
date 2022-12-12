using Game.Scripts.Collectables.Base;
using Game.Scripts.Managers.GoldManagement.Base;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Collectables
{
    public class GoldCollectable : CollectableBase
    {
        [SerializeField] private int _goldAmount = 1;
        [Inject] private GoldManager _goldManager;       
        protected override void OnCollected()
        {
            _goldManager.AddGold(_goldAmount);
            gameObject.SetActive(false);
        }
    }
}