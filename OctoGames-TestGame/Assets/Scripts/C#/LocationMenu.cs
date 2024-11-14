using UnityEngine;

public class LocationMenu : MonoBehaviour
{
	[SerializeField] GameObject _locationMenu;
	[SerializeField] Animator _animator;

	public void ShowLocButton()
	{
		gameObject.SetActive(true);
		_animator.SetBool("Active", true);
	}

	public void HideLocButton()
	{
		_animator.SetBool("Active", false);
	}
}