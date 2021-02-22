using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NK 
{
	public class InputManager : MonoBehaviour
	{
		private PlayerControls playerControls;

        private void Awake()
        {
            playerControls = new PlayerControls();
        }

        #region OnEnable / OnDisable

        private void OnEnable()
        {
            playerControls.Enable();
        }

        private void OnDisable()
        {
            playerControls.Disable();
        }

        #endregion

        #region Gameplay

        public Vector2 GetMovement(bool returnRawMovement = false)
        {
            Vector2 rawMovement = playerControls.Gameplay.Movement.ReadValue<Vector2>();

            if (returnRawMovement == true)
            {
                return rawMovement;
            }
            else
            {
                int normalizedInputX = (int)(rawMovement * Vector2.right).normalized.x;
                int normalizedInputY = (int)(rawMovement * Vector2.up).normalized.y;
                return new Vector2(normalizedInputX, normalizedInputY);
            }
        }

        public bool GetJump()
        {
            return playerControls.Gameplay.Jump.triggered;
        }

        #endregion

    }
}
