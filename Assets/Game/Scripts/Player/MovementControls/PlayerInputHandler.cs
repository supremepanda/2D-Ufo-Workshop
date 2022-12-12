using Game.Scripts.Player.MovementControls.Input.Base;
using UnityEngine;

namespace Game.Scripts.Player.MovementControls
{
    public class PlayerInputHandler : InputHandler
    {
        protected override Vector2 CalculateInput()
        {
            var inputX = UnityEngine.Input.GetAxis("Horizontal");
            var inputY = UnityEngine.Input.GetAxis("Vertical");
            return new Vector2(inputX, inputY);
        }
    }
}