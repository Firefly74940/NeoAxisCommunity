using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AddonUtils;

namespace Engine.Utils
{
	class DebugWindowAddon : CommunityGameAddon
	{
		DebugWindow window; //Debug window dll

		public override bool OnKeyDown(KeyEvent e)
		{
			if( e.Key == EKeys.PageUp )
			{
				//the order of if's is important
				// ScreenControlManager.Instance.Controls.Add(new MenuWindow());
				//DebugWindow.Instance.Show();

				if( window == null )//create
				{
					if( DebugWindow.Instance == null )
					{
						window = new DebugWindow();
					}
					else
					{
						window = DebugWindow.Instance;
					}
					window.Show();
					window.SaveEntityType();
					window.RegisterToMapTick();
					EngineApp.Instance.MouseRelativeMode = window.Visible;
				}
				else if( window != null && window.Visible )
				{
					window.Close();
					window = null;
					EngineApp.Instance.MouseRelativeMode = false;
				}
				else //if( window != null && !window.Visible )
				{
					window.Visible = true;
					window.Activate();
					EngineApp.Instance.MouseRelativeMode = window.Visible;
				}
			}
			return base.OnKeyDown(e);
		}

		public override void OnCloseAddon()
		{
			if( window != null )
			{
				window.Close();
				window = null;
			}
		}
	}
}
