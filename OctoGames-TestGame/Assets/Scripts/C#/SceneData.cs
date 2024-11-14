using UnityEngine;

public class SceneData : MonoBehaviour
{
	public static SceneData Instance;

	#region Values
	[Header("Anna")]
	[SerializeField] private GameObject Anna;
	[SerializeField] private LadiesCommands _annaComands;
	[Header("Valeria")]
	[SerializeField] private GameObject Valeria;
	[SerializeField] private LadiesCommands _valeriaComands;
	[Header("UI")]
	[SerializeField] private LocationMenu _locationMenu;
	[Header("Services")]
	[SerializeField] private NaninovelScriptsStarter _naninovelScriptsStarter;
	[SerializeField] private MiniGameController _miniGameController;
	[SerializeField] private QuestsConroller _questsConroller;
	[SerializeField] private LocalizationController _localizationController;
	#endregion

	#region Init
	public LadiesCommands AnnaComands => _annaComands;
	public LadiesCommands ValeriaCommands => _valeriaComands;
	public LocationMenu LocationMenu => _locationMenu;
	public NaninovelScriptsStarter NaninovelScriptsStarter => _naninovelScriptsStarter;
	public MiniGameController MiniGameController => _miniGameController;
	public QuestsConroller QuestsConroller => _questsConroller;
	public LocalizationController LocalizationController => _localizationController;
	#endregion

	private GameObject _currentLady;
	private void Awake()
	{
		Instance = this;
	}
}