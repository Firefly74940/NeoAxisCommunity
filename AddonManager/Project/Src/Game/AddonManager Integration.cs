// inside Src/Game/GameEngineApp.cs
namespace Game
{
	public class GameEngineApp : EngineApp
	{
		protected override bool OnCreate()//inside this method
		{
			//
			// default code from SDK 
			//
			
			//add this:
			CommunityGameAddonManager.DevMod = true;
			CommunityGameAddonManager.Init();
			#endregion
			return true; //Last Line of SDK default Code
		}
		protected override bool OnKeyDown( KeyEvent e )//inside this method
		{
			//
			// default code from SDK 
			//
			
			//add this:
			if (CommunityGameAddonManager.Instance.OnKeyDown(e))
				return true;
			
			KeyDownLogicEventManager.SendKeyDownEvent(e.Key );// 2 last lines of SDK default Code
			return base.OnKeyDown( e );
		}
	}
}
// inside Src/Game/ActionGameWindow.cs
namespace Game
{
	public partial class ActionGameWindow : GameWindow
	{
		protected override void OnDetach()//inside this method
		{
			//accept commands of the player
			GameControlsManager.Instance.GameControlsEvent -= GameControlsManager_GameControlsEvent;// default code from SDK 
			CommunityGameAddonManager.Instance.CloseAddons(); //Add This Line
			base.OnDetach();// default code from SDK 
		}
	}
}