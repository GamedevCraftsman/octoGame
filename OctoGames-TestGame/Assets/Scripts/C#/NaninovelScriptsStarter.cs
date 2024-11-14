using UnityEngine;
using Naninovel;
using System.Threading.Tasks;

public class NaninovelScriptsStarter : MonoBehaviour
{
	private async Task PlayNaninovelScript(string _scriptName)
	{
		var scriptPlayer = Engine.GetService<IScriptPlayer>();
		var scriptManager = Engine.GetService<IScriptManager>();

		var script = await scriptManager.LoadScriptAsync(_scriptName);

		if (script != null)
		{
			await scriptPlayer.PreloadAndPlayAsync(_scriptName);
		}
		else
		{
			Debug.LogWarning($"Script '{_scriptName}' isn`t valid.");
		}
	}

	public async void CallNaninovelScript(string _scriptName)
	{
		await PlayNaninovelScript(_scriptName);
	}
}