using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NK
{
	[CreateAssetMenu(menuName = "Data/Player Data/Base Data", fileName = "New Player Data")]
	public class PlayerData : ScriptableObject
	{
		[Title("Move State")]
		public float movementSpeed = 10f;
	}
}
