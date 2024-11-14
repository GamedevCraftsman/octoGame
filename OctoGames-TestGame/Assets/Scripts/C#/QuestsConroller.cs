using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestsConroller : MonoBehaviour
{

	[SerializeField] private TMP_Text _questText;
	[SerializeField] private Button _bossCabinetButton;
	[SerializeField] private GameObject _concertTicket;
	[SerializeField] private GameObject _questLog;

	private int _questNumber = 0;
	private string _hideQuestLogAnimationName = "Hide";
	public void DiableBossCabinetBut()
	{
		_bossCabinetButton.interactable = false;
	}

	public void ActivateTicket()
	{
		_concertTicket.SetActive(true);
	}

	public void ShowQuestLog()
	{
		_questLog.SetActive(true);
		_questLog.GetComponent<Animator>().SetTrigger("Show");
	}

	public void HideQuestLog()
	{
		StartCoroutine(OffQuestLogPanel());
	}

	private IEnumerator OffQuestLogPanel()
	{
		float _animDur = GetAnimationLength(_hideQuestLogAnimationName);

		_questLog.GetComponent<Animator>().SetTrigger("Hide");
		yield return new WaitForSeconds(_animDur);
		_questLog.SetActive(false);
	}

	public void GoToNextQuest()
	{
		StartCoroutine(ChangeQuest());
	}

	private IEnumerator ChangeQuest()
	{
		if (!isQuestFirst())
		{
			_questText.text = $"<s>{_questText.text}</s>";

			yield return new WaitForSeconds(1);
			ChangeQuestText();
		}
		else
		{
			SetFirstQuest();
		}
	}

	private void SetFirstQuest()
	{
		_questText.text = SceneData.Instance.LocalizationController.QuestsList[_questNumber];
		_questNumber++;
	}

	private bool isQuestFirst()
	{
		return _questNumber == 0;
	}

	private void ChangeQuestText()
	{
		_questText.text = SceneData.Instance.LocalizationController.QuestsList[_questNumber];

		_questNumber++;
	}

	private float GetAnimationLength(string name)
	{
		AnimationClip[] _clips = _questLog.GetComponent<Animator>().runtimeAnimatorController.animationClips;

		foreach (AnimationClip clip in _clips)
		{
			if (clip.name == name)
			{
				return clip.length;
			}
		}
		return 0;
	}
}
