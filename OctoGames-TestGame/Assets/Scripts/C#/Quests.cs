using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Quests", menuName = "ScriptableObjects/Quests", order = 1)]
public class Quests : ScriptableObject
{
	[SerializeField] private List<string> _quests = new List<string>();

	public IReadOnlyList<string> QuestsList => _quests;
}
