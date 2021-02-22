using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NK 
{
	[CreateAssetMenu(menuName = "Data/Animation Data/Player Animations", fileName = "New Player Animations")]
	public class PlayerAnimationData : ScriptableObject
	{
		public string IDLE = "idle";
		public string MOVE = "move";
	}
}
