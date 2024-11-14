using Naninovel;

#region AnnaCommands
[CommandAlias("showAnna")]
public class ShowAnna : Command
{
	public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
	{
		var actions = SceneData.Instance.AnnaComands;
		if (actions != null)
		{
			actions.ShowSceneLady();
		}

		return UniTask.CompletedTask;
	}
}

[CommandAlias("hideAnna")]
public class HideAnna : Command
{
	public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
	{
		var actions = SceneData.Instance.AnnaComands;
		if (actions != null)
		{
			actions.HideSceneLady();
		}

		return UniTask.CompletedTask;
	}
}
#endregion

#region LocationButtonCommands
[CommandAlias("showLocationBut")]
public class ShowLocationBut : Command
{
	public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
	{
		var actions = SceneData.Instance.LocationMenu;
		if (actions != null)
		{
			actions.ShowLocButton();
		}

		return UniTask.CompletedTask;
	}
}

[CommandAlias("hideLocationBut")]
public class HideLocationBut : Command
{
	public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
	{
		var actions = SceneData.Instance.LocationMenu;
		if (actions != null)
		{
			actions.HideLocButton();
		}

		return UniTask.CompletedTask;
	}
}
#endregion

#region MiniGameCommands
[CommandAlias("startMiniGame")]
public class StartMiniGame : Command
{
	public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
	{
		var actions = SceneData.Instance.MiniGameController;
		if (actions != null)
		{
			actions.StartMiniGame();
		}

		return UniTask.CompletedTask;
	}
}
#endregion

#region ValeriaCommands
[CommandAlias("showValeria")]
public class ShowValeria : Command
{
	public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
	{
		var actions = SceneData.Instance.ValeriaCommands;
		if (actions != null)
		{
			actions.ShowSceneLady();
		}

		return UniTask.CompletedTask;
	}
}

[CommandAlias("hideValeria")]
public class HideValeria : Command
{
	public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
	{
		var actions = SceneData.Instance.ValeriaCommands;
		if (actions != null)
		{
			actions.HideSceneLady();
		}

		return UniTask.CompletedTask;
	}
}
#endregion

#region MyCabinetCommands
[CommandAlias("disableMyCabBut")]
public class DisableMyCabBut : Command
{
	public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
	{
		var actions = SceneData.Instance.QuestsConroller;
		if (actions != null)
		{
			actions.DiableBossCabinetBut();
		}

		return UniTask.CompletedTask;
	}
}

[CommandAlias("activateConcertTicket")]
public class ActivateConcertTicket : Command
{
	public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
	{
		var actions = SceneData.Instance.QuestsConroller;
		if (actions != null)
		{
			actions.ActivateTicket();
		}

		return UniTask.CompletedTask;
	}
}
#endregion

#region QuestCommands
[CommandAlias("changeQuest")]
public class ChangeQuest : Command
{
	public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
	{
		var actions = SceneData.Instance.QuestsConroller;
		if (actions != null)
		{
			actions.GoToNextQuest();
		}

		return UniTask.CompletedTask;
	}
}

[CommandAlias("showQuestLog")]
public class ShowQuestLog : Command
{
	public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
	{
		var actions = SceneData.Instance.QuestsConroller;
		if (actions != null)
		{
			actions.ShowQuestLog();
		}

		return UniTask.CompletedTask;
	}
}

[CommandAlias("hideQuestLog")]
public class HideQuestLog : Command
{
	public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
	{
		var actions = SceneData.Instance.QuestsConroller;
		if (actions != null)
		{
			actions.HideQuestLog();
		}

		return UniTask.CompletedTask;
	}
}
#endregion