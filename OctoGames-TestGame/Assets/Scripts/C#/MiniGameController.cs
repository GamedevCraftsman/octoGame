using DTT.MinigameMemory;
using System.Collections;
using UnityEngine;

public class MiniGameController : MonoBehaviour
{
	[Header("Gameobjects")]
	[SerializeField] GameObject _miniGamePanel;
	[SerializeField] GameObject _blackPanel;
	[Header("Settings")]
	[SerializeField] MemoryGameManager _memoryGameManager;
	[SerializeField] MemoryGameSettings _memoryGameSettings;
	[SerializeField] MemoryGameResults _memoryGameResults;

	private Animator _blackPanelAnimator;
	private string _nameOfFadeAnim = "BlackPanelAnim";
	private void Start()
	{
		_blackPanelAnimator = _blackPanel.GetComponent<Animator>();
	}

	public void StartMiniGame()
	{
		StartCoroutine(MiniGameCoroutine());
	}

	public IEnumerator MiniGameCoroutine()
	{
		float _animDuration = GetAnimationLength(_nameOfFadeAnim);

		StartCoroutine(ActivateMinigame(true, _animDuration));
		yield return new WaitForSeconds(_animDuration);

		_memoryGameManager.StartGame(_memoryGameSettings);

		yield return new WaitUntil(() => !_memoryGameManager.IsGameActive);

		StartCoroutine(ActivateMinigame(false, _animDuration));
	}

	private IEnumerator ActivateMinigame(bool isActive, float _animDuration)
	{

		_blackPanel.SetActive(true);
		_blackPanelAnimator.SetTrigger("Activate");

		yield return new WaitForSeconds(_animDuration / 2);
		_miniGamePanel.SetActive(isActive);
		yield return new WaitForSeconds(_animDuration / 2);
		_blackPanel.SetActive(false);
	}

	private float GetAnimationLength(string name)
	{
		foreach (AnimationClip clip in _blackPanelAnimator.runtimeAnimatorController.animationClips)
		{
			if (clip.name == name)
			{
				return clip.length;
			}
		}
		return 0;
	}
}
