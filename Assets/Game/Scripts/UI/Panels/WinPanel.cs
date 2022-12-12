using Game.Scripts.Managers.LevelCompletionManagement.Base;
using Game.Scripts.UI.Panels.Base;
using UnityEngine;
using Zenject;

namespace Game.Scripts.UI.Panels
{
    public class WinPanel : UIPanelBase
    {
        [SerializeField] private GameObject _winPanelHolder;
        [Inject] private LevelCompletionManager _levelCompletionManager;
        private void OnEnable()
        {
            _levelCompletionManager.LevelCompleted += SetActive;
        }

        private void OnDisable()
        {
            _levelCompletionManager.LevelCompleted -= SetActive;
        }

        public override void Activate(bool flag)
        {
            _winPanelHolder.SetActive(flag);
        }
    }
}