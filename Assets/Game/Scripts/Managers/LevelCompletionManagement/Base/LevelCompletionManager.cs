using System;

namespace Game.Scripts.Managers.LevelCompletionManagement.Base
{
    public abstract class LevelCompletionManager
    {
        public event Action LevelCompleted;

        public LevelCompletionManager(){}
        
        public virtual void OnLevelCompleted()
        {
            LevelCompleted?.Invoke();
        }
    }
}