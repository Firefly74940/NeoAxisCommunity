Implementation code for animated Cursor: 

1) Add a refencence to advanced control dll in Game project

2) in GameEngineApp.cs 
  replace 
    ScreenControlManager controlManager;
  by 
    AdvancedScreenControlManager controlManager;

	2.1) in OnCreate method
	    replace 
		  controlManager = new ScreenControlManager( ScreenGuiRenderer );
		by
		  controlManager = new AdvancedScreenControlManager( ScreenGuiRenderer );
	
	    after 
		  _ShowSystemCursor = _ShowSystemCursor;
		add
		  	controlManager.CursorFrameSize = 64; //size of cusor on sprite
			controlManager.CursorFrameCount = 18;//number of cursor on sprite
			controlManager.CenterCursor = true;  // if cursor should be rendered on topleft or center
			controlManager.CursorFPS = 24;  //cursor animation speed
			controlManager.CursorRenderFrameSize = 32; //render size, so you can have a big texture and change the size rendered
			controlManager.CurrentCursor = "GUI\\Cursors\\Animated.png"; //path to your cursor texture