using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Engine.EntitySystem;
using Engine.MapSystem;
using EditorBase;
using Irony.Interpreter.Evaluator;
using Irony.Parsing;
using AddonUtils;

namespace Engine.Utils
{
	public partial class DebugWindow : Form
	{

		private readonly List<object> _objectList = new List<object>();
		private readonly List<object> _customObjectList = new List<object>();

		private static DebugWindow _instance;

		private object _currentObject;

		public static DebugWindow Instance
		{
			get
			{
				if( _instance == null )
					_instance = new DebugWindow();
				return _instance;
			}
		}

		public DebugWindow()
		{

			if( _instance != null )
				Log.Fatal( "Debug Window already created" );

			_instance = this;

			InitializeComponent();
		}

		private void DebugForm_Load( object sender, EventArgs e )
		{
			RefreshAll();

			ResourceUtils.OnUITypeEditorEditValue += new ResourceUtils.OnUITypeEditorEditValueDelegate( ResourceUtils_OnUITypeEditorEditValue );

			ResourceTypeManager.Init();

			//Register default types
			ResourceTypeManager.Instance.Register( new ResourceType( "Texture", "Texture",
	 new string[] { 
					"jpg", "jif", "jpeg", "jpe", "tga", "targa", "dds", "png", "bmp", "psd", "hdr", "ico", 
					"gif", "tif", "tiff", "exr", "j2k", "j2c", "jp2" },
	 DefaultResourceTypeImages.GetByName( "Texture_16" ) ) );
			ResourceTypeManager.Instance.Register( new ResourceType( "Mesh", "Mesh",
				new string[] { "mesh" }, DefaultResourceTypeImages.GetByName( "Mesh_16" ) ) );
			ResourceTypeManager.Instance.Register( new ResourceType( "PhysicsModel", "Physics Model",
				new string[] { "physics" }, DefaultResourceTypeImages.GetByName( "PhysicsModel_16" ) ) );
			ResourceTypeManager.Instance.Register( new ResourceType( "EntityType", "Entity Type",
				new string[] { "type" }, DefaultResourceTypeImages.GetByName( "EntityType_16" ) ) );
			ResourceTypeManager.Instance.Register( new ResourceType( "ParticleSystem", "Particle System",
				new string[] { "particle" },
				DefaultResourceTypeImages.GetByName( "ParticleSystem_16" ) ) );
			ResourceTypeManager.Instance.Register( new ResourceType( "Material", "Material",
				new string[] { "highMaterial" }, DefaultResourceTypeImages.GetByName( "Material_16" ) ) );
			ResourceTypeManager.Instance.Register( new ResourceType( "GUI", "Graphic User Interface",
				new string[] { "gui" }, DefaultResourceTypeImages.GetByName( "Gui_16" ) ) );
			ResourceTypeManager.Instance.Register( new ResourceType( "Sound", "Sound",
				new string[] { "ogg", "wav" }, DefaultResourceTypeImages.GetByName( "Sound_16" ) ) );
			ResourceTypeManager.Instance.Register( new ResourceType( "Video", "Video",
				new string[] { "ogv" }, DefaultResourceTypeImages.GetByName( "Video_16" ) ) );
			ResourceTypeManager.Instance.Register( new ResourceType( "Language", "Language",
				new string[] { "language" }, DefaultResourceTypeImages.GetByName( "Language_16" ) ) );
			ResourceTypeManager.Instance.Register( new ResourceType( "Skeleton", "Skeleton",
				new string[] { "skeleton" }, DefaultResourceTypeImages.GetByName( "Skeleton_16" ) ) );
			ResourceTypeManager.Instance.Register( new ResourceType( "FontDefinition", "Font Definition",
				new string[] { "fontDefinition" }, DefaultResourceTypeImages.GetByName( "FontDefinition_16" ) ) );
			ResourceTypeManager.Instance.Register( new ResourceType( "AnimationTree", "Animation Tree",
				new string[] { "animationTree" }, DefaultResourceTypeImages.GetByName( "AnimationTree_16" ) ) );

		}

		void Instance_Tick( Entity entity )
		{
			if( checkBoxLive.Checked )
				propEditor.Refresh();
			if( propEditor.SelectedObject != null )
			{
				var utils = new AddonUtils.Utils();
				ResetInterpretor(); // reset before execution
				foreach( var row in this.dataGridView1.Rows )
				{
					var Row = row as DataGridViewRow;
					if( Row.Cells[ 0 ].Value == null ) continue;

					#region Irony interpreter v1
					//Grammar _grammar = new ExpressionEvaluatorGrammar();
					//ParseTree _parseTree;
					//var _language = new LanguageData( _grammar );
					//var _parser = new Parser( _language );
					//try
					//{
					//	_parser.Parse(Row.Cells[0].Value.ToString(), "<source>");
					//}
					//catch (Exception ex)
					//{
					//	Row.Cells[1].Value=ex.Message;
					//	Row.Cells[ 0 ].Style.BackColor = Color.Red;
					//	throw;
					//}
					//finally
					//{
					//	_parseTree = _parser.Context.CurrentParseTree;
					//}
					//if( _parseTree.ParserMessages.Count > 0 ) continue;


					//var iRunner = _grammar as ExpressionEvaluatorGrammar;
					//var args = new RunSampleArgs( _language, Row.Cells[ 0 ].Value.ToString(), _parseTree );
					//args.mainObject = propEditor.SelectedObject;
					////string output = iRunner.RunSample( args );

					//try
					//{
					//	Row.Cells[ 1 ].Value = iRunner.RunSampleCustom( args );
					//	Row.Cells[ 0 ].Style.BackColor = Row.DefaultCellStyle.BackColor;
					//	continue;
					//}
					//catch( Exception )
					//{
					//	Row.Cells[ 0 ].Style.BackColor = Color.Red;
					//	continue;
					//}

					#endregion
					var code = Row.Cells[ 0 ].Value.ToString();

					if( !code.Contains( "_this." ) )
					{
						#region Irony interpreter v2
						object result;

						if( TryInterpret( code, out result ) )
						{
							Row.Cells[ 0 ].Style.BackColor = Row.DefaultCellStyle.BackColor;
						}
						else
						{
							Row.Cells[ 0 ].Style.BackColor = Color.Red;
						}
						Row.Cells[ 1 ].Value = result;
						#endregion
					}
					else
					{
						code = code.Replace( "_this.", "" );
						var fieldValue = utils.GetFieldValue( propEditor.SelectedObject, code, false );
						if( fieldValue != null )
						{
							Row.Cells[ 0 ].Style.BackColor = Row.DefaultCellStyle.BackColor;
							Row.Cells[ 1 ].Value = fieldValue;
							continue;
						}
						Row.Cells[ 0 ].Style.BackColor = Color.Red;
					}




				}
				if( dataGridView1.SelectedCells.Count > 0 )
					WatcherViever.SelectedObject = dataGridView1.Rows[ dataGridView1.SelectedCells[ 0 ].RowIndex ].Cells[ 1 ].Value;
			}
		}

		Grammar _grammar;
		LanguageData _language;
		Parser _parser;

		void ResetInterpretor()
		{
			_grammar = new ExpressionEvaluatorGrammar();
			_language = new LanguageData( _grammar );
			_parser = new Parser( _language );
		}
		bool TryInterpret( string code, out object result )
		{
			#region Irony interpreter

			ParseTree _parseTree;
			try
			{
				_parser.Parse( code, "<source>" );
			}
			catch( Exception ex )
			{
				result = ex.Message;

				return false;
			}
			finally
			{
				_parseTree = _parser.Context.CurrentParseTree;
			}
			if( _parseTree.ParserMessages.Count > 0 )
			{
				result = _parseTree.ParserMessages[ 0 ];
				return false;
			}

			var iRunner = _grammar as ExpressionEvaluatorGrammar;
			var args = new RunSampleArgs( _language, code, _parseTree );
			args.mainObject = propEditor.SelectedObject;

			try
			{
				result = iRunner.RunSampleCustom( args );
				return true;
			}
			catch( Exception e )
			{
				result = e.Message;
				return false;
			}
			#endregion
		}
		void ResourceUtils_OnUITypeEditorEditValue( ResourceUtils.ResourceUITypeEditorEditValueEventHandler e )
		{
			ResourceType resourceType = ResourceTypeManager.Instance.GetByName( e.ResourceTypeName );
			if( resourceType == null )
				Log.Fatal( "Resource type not defined \"{0}\"", e.ResourceTypeName );

			ChooseResourceForm dialog = new ChooseResourceForm( resourceType,
				true, e.ShouldAddDelegate, e.ResourceName, true );

			if( dialog.ShowDialog() == DialogResult.OK )
			{
				e.ResourceName = dialog.FilePath;
				e.Modified = true;
			}
		}

		void RefreshObjectList()
		{

			_objectList.Clear();

			if( _currentObject == null )
				_currentObject = Map.Instance;

			if( _currentObject is Map )
			{

				foreach( Entity entity in Map.Instance.Children )
				{
					_objectList.Add( entity );
				}

			}
			else if( _currentObject is Entity )
			{

				Entity currentEntity = _currentObject as Entity;

				if( currentEntity != null )
				{

					foreach( Entity entity in currentEntity.Children )
					{
						_objectList.Add( entity );
					}

				}

				return;

			}

			foreach( object obj in _customObjectList )
			{
				_objectList.Add( obj );
			}

		}

		public void AddCustomObject( object customObject )
		{
			if( !_customObjectList.Contains( customObject ) )
				_customObjectList.Add( customObject );
		}

		public void RemoveCustomObject( object customObject )
		{
			_customObjectList.Remove( customObject );
		}

		public void ClearCustomObjectList()
		{
			_customObjectList.Clear();
		}

		void RefreshEntityList()
		{

			//entityList.SuspendLayout();
			entityList.BeginUpdate();
			entityList.Items.Clear();

			foreach( object obj in _objectList )
			{
				if(checkBoxHideStatic.Checked && obj is StaticMesh) continue;
				
				Entity entity = obj as Entity;

				var filter = textBoxFilter.Text.ToLower();
				if( entity != null )
				{
					var hasAName = entity.Name != string.Empty;
					string name = hasAName ? entity.Name : entity.Type.Name;

					string type = entity.Type.Name;

					if( filter != string.Empty &&
						!( name.ToLower().Contains( filter ) ||
						( hasAName && type.ToLower().Contains( filter ) ) ) )
						continue;

					ListViewItem item = new ListViewItem( name );

					item.SubItems.Add( type );

					item.SubItems.Add( entity.Children.Count.ToString() );

					item.Tag = entity;

					entityList.Items.Add( item );

				}
				else
				{

					string name = obj.ToString();

					string type = obj.GetType().Name;

					if( filter != string.Empty &&
						!( name.ToLower().Contains( filter ) ||
						type.ToLower().Contains( filter ) ) )
						continue;

					ListViewItem item = new ListViewItem( name );

					item.SubItems.Add( type );

					entityList.Items.Add( item );

				}




			}
			entityList.EndUpdate();
			//entityList.ResumeLayout();

		}

		public void RefreshAll()
		{
			RefreshObjectList();
			RefreshEntityList();
		}

		private void DebugWindow_FormClosing( object sender, FormClosingEventArgs e )
		{
			e.Cancel = true;
			Visible = false;
			if( Map.Instance != null )
				Map.Instance.Tick -= Instance_Tick;
		}


		private void DebugWindow_MouseLeave( object sender, EventArgs e )
		{
			//DeadWake.GameEngineApp.Instance.MouseRelativeMode = mouseRealativeMode;
			//DeadWake.GameEngineApp.Instance.ShowSystemCursor = showSystemCursor;
			//EntitySystemWorld.Instance.Simulation = true;
		}

		private void DebugWindow_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Escape )
				Visible = false;
		}


		private void entityList_SelectedIndexChanged( object sender, EventArgs e )
		{
			propEditor.SelectedObject = propEditor.SelectedObject = null;

			typeEditor.SelectedObject = typeEditor.SelectedObjects = null;


			if( entityList.SelectedItems.Count == 1 )
			{

				propEditor.SelectedObject = entityList.SelectedItems[ 0 ].Tag;

				Entity entity = entityList.SelectedItems[ 0 ].Tag as Entity;

				if( entity != null )
				{
					typeEditor.SelectedObject = entity.Type;
					propEditor.SelectedObject = entity;
				}
			}

			else if( entityList.SelectedItems.Count > 1 )
			{

				//object[] entities = new object[entityList.SelectedItems.Count - 1];

				List<object> entities = new List<object>();
				List<object> types = new List<object>();

				foreach( ListViewItem item in entityList.SelectedItems )
				{
					entities.Add( item.Tag );

					Entity entity = item.Tag as Entity;

					if( entity != null )
						types.Add( entity.Type );


				}

				propEditor.SelectedObjects = entities.ToArray();
				typeEditor.SelectedObjects = types.ToArray();
			}

		}

		private void DebugWindow_Activated( object sender, EventArgs e )
		{
			/*mouseRealativeMode = EngineApp.Instance.MouseRelativeMode;
			showSystemCursor = EngineApp.Instance.ShowSystemCursor;
			simulation = EntitySystemWorld.Instance.Simulation;
			DeadWake.GameEngineApp.Instance.MouseRelativeMode = false;
			DeadWake.GameEngineApp.Instance.ShowSystemCursor = true;
			EntitySystemWorld.Instance.Simulation = false;*/
		}


		private void textBoxFilter_TextChanged( object sender, EventArgs e )
		{
			RefreshEntityList();
		}
		private void checkBoxShowStatic_CheckedChanged( object sender, EventArgs e )
		{
			RefreshEntityList();
		}
		private void entityList_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Escape )
				Visible = false;

			if( e.KeyCode == Keys.Back )
			{
				GoOneUp();
			}

		}

		private void textBoxFilter_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Escape )
				Visible = false;
		}

		private void checkBoxTopMost_CheckedChanged( object sender, EventArgs e )
		{
			TopMost = checkBoxTopMost.Checked;
		}

		private void buttonRefresh_Click( object sender, EventArgs e )
		{
			RefreshAll();
		}
		
		private void GoOneUp()
		{
			if( _currentObject == null )
			{
				_currentObject = Map.Instance;
				RefreshAll();
				return;
			}

			Entity entity = _currentObject as Entity;

			if( entity == null )
				return;

			if( entity.Parent == null )
			{
				_currentObject = Map.Instance;
				RefreshAll();
				return;
			}

			_currentObject = entity.Parent;

			RefreshAll();

		}

		private void entityList_DoubleClick( object sender, EventArgs e )
		{

			if( entityList.SelectedItems.Count == 0 || entityList.SelectedItems.Count > 1 )
				return;

			ListViewItem item = entityList.SelectedItems[ 0 ];


			Entity entity = item.Tag as Entity;

			if( entity != null && entity.Children.Count > 0 )
			{
				_currentObject = entity;
				RefreshAll();
			}

		}

		private void buttonUP_Click( object sender, EventArgs e )
		{
			GoOneUp();
		}

		private void buttonSaveType_Click( object sender, EventArgs e )
		{
			SaveEntityType();
		}

		public object[] GetCurrentSelection()
		{
			List<object> objectSelection = new List<object>();

			foreach( ListViewItem item in entityList.SelectedItems )
			{
				objectSelection.Add( item.Tag );
			}

			return objectSelection.ToArray();

		}

		public void SaveEntityType()
		{
			object[] entities = GetCurrentSelection();

			foreach( Entity entity in entities )
			{
				EntityTypes.Instance.SaveTypeToFile( entity.Type );
			}

		}

		public void SaveEntitiesType( List<Entity> entities )
		{

			foreach( Entity entity in entities )
			{
				EntityTypes.Instance.SaveTypeToFile( entity.Type );
			}
		}

		public void SaveEntityType( Entity entity )
		{
			if( entity != null )
			{
				EntityTypes.Instance.SaveTypeToFile( entity.Type );
			}
		}

		public void SaveEntityType( EntityType type )
		{
			if( type != null )
			{
				EntityTypes.Instance.SaveTypeToFile( type );
			}
		}

		private void checkBoxTransparent_CheckedChanged( object sender, EventArgs e )
		{
			if( checkBoxTransparent.Checked )
				Opacity = 0.75;
			else
				Opacity = 1.0;
		}



		private void propEditor_SelectedGridItemChanged( object sender, SelectedGridItemChangedEventArgs e )
		{

		}

		private void propEditor_Click( object sender, EventArgs e )
		{

		}

		public void RegisterToMapTick()
		{
			if( Map.Instance != null )
				Map.Instance.Tick += Instance_Tick;
		}

		private void checkbox_advanced_CheckedChanged( object sender, EventArgs e )
		{
			var advancedMode = checkbox_advanced.Checked;
			splitContainer3.Panel2Collapsed = !advancedMode;
			splitContainer5.Panel2Collapsed = !advancedMode;
			//propEditor.Size = advancedMode ? new Size( propEditor.Size.Width, propEditor.Size.Height / 2 ) : new Size( propEditor.Size.Width, propEditor.Size.Height * 2 );
			//checkBoxLive.Visible = advancedMode;
			//checkBoxLive.Checked = advancedMode;
			//dataGridView1.Visible = advancedMode;
		}

		List<string> _consoleHistory = new List<string>();
		private int _historyIndex = -1;

		private void console_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Enter )
			{
				var code = console.Text;
				object result;
				TryInterpret( code, out result );


				consoleLog.AppendLine( code );
				consoleLog.AppendLine( result.ToString() );
				console.Text = "";

				if( _consoleHistory.Count == 0 || _consoleHistory[ _consoleHistory.Count - 1 ] != code )
					_consoleHistory.Add( code );

				_historyIndex = _consoleHistory.Count; //lastIndex+1
			}
			if( e.KeyCode == Keys.Up )
			{
				if( _historyIndex >= 1 )
				{
					_historyIndex--;
					console.Text = _consoleHistory[ _historyIndex ];
				}

			}
			if( e.KeyCode == Keys.Down )
			{
				if( _historyIndex > -1 && _historyIndex < _consoleHistory.Count - 1 )
				{
					_historyIndex++;
					console.Text = _consoleHistory[ _historyIndex ];
				}
			}
		}

		

	}
	public static class WinFormsExtensions
	{
		public static void AppendLine( this TextBox source, string value )
		{
			if( source.Text.Length == 0 )
				source.Text = value;
			else
				source.AppendText( "\r\n" + value );
		}
	}
}
