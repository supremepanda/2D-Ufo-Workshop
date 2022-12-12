using Game.Scripts.UI.Buttons.Base;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Game.Scripts.UI.Buttons
{
    public class RestartGameButton : UIButtonBase
    {
        protected override UnityAction OnClickActions()
        {
            return () =>
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            };
        }
    }
}