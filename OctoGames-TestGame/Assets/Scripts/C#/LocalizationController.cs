using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;

public class LocalizationController : MonoBehaviour
{
    [Header("Quest")]
	[SerializeField] private Quests _defaultQuests;
	[SerializeField] private Quests _ukrainianQuests;

	public IReadOnlyList<string> QuestsList { get; set; }

	void Update()
    {
        SetLocalization();
    }



    private void SetLocalization()
    {
        var _localizationManager = Engine.GetService<LocalizationManager>();

        if(_localizationManager != null )
        {
            Debug.Log(_localizationManager.SelectedLocale);
            ChooseLanguage(_localizationManager.SelectedLocale);    
        }
        else
        {
            Debug.LogError("Haven`t correct localization!");
        }
    }

    private void ChooseLanguage(string _langID)
    {
        if(_langID == "en")
        {
            QuestsList = _defaultQuests.QuestsList;
        }
        else if( _langID == "uk")
        {
            QuestsList = _ukrainianQuests.QuestsList;
        }
    }
}
