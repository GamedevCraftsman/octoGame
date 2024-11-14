using UnityEngine;

public class LadiesCommands : MonoBehaviour
{
    [SerializeField] private GameObject _ladyGameobject;

    public void ShowSceneLady()
    {
        _ladyGameobject.SetActive(true);
    }

	public void HideSceneLady()
	{
		_ladyGameobject.SetActive(false);
	}
}
