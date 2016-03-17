// inside Src/ProjectEntities/Action Specific/Character.cs
namespace ProjectEntities
{
	public partial class Character : Unit // Set Class Partial
	{
		protected override void OnTick() //inside this method
		{
			//
			// default code from SDK 
			//
			//End of default SDK code
			
			//add this:
			#region Ladders

			if( Intellect != null )
				TickLadder();

			#endregion
		}
		void TickJump( bool ignoreTicks )//inside this method
		{
			if( IsOnGround() && onGroundTime > TickDelta && jumpInactiveTime == 0 && shouldJumpTime != 0 )//Default SDK code, do not change
			{                                                                                             //Default SDK code, do not change
				  // default code from SDK                                                                                         //Default SDK code, do not change
			}                                                                                             //Default SDK code, do not change
			#region Ladders  //add this:
			else if( currentLadder != null && shouldJumpTime != 0 )
			{
				JumpFromLadder();
			}
			#endregion
		}
	}
}