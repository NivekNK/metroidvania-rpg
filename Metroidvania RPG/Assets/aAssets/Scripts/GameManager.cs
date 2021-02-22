using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NK 
{
	public class GameManager : MonoBehaviour
	{
        public InputManager inputManager { get; private set; }

        private static GameManager _instance;

        public static GameManager Instance { get { return _instance; } }

        private void Awake()
        {
            if (_instance != null && _instance != this)
                Destroy(this.gameObject);
            else
                _instance = this;

            GetVariables();
        }

        private void GetVariables()
        {
            inputManager = GetComponent<InputManager>();
        }
    }
}
