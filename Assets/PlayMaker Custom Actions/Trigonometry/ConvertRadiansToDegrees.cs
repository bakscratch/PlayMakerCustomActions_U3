// (c) Copyright HutongGames, LLC 2010-2015. All rights reserved.
/*--- __ECO__ __ACTION__ ---*/

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Trigonometry")]
	[Tooltip("Convert Radians to Degrees. This is using a constant: 360 / (PI * 2).")]
	public class ConvertRadiansToDegrees : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The angle expressed in radians")]
		public FsmFloat angleInRadians;
		
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The angle in degrees")]
		public FsmFloat angleInDegrees;
				
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
			angleInDegrees = null;
			everyFrame = false;
			angleInRadians = null;
		}

		public override void OnEnter()
		{
			DoConvertion();
			
			if (!everyFrame)
			{
				Finish();
			}
		}

		public override void OnUpdate()
		{
			DoConvertion();
		}
		
		void DoConvertion()
		{
		 	angleInDegrees.Value = angleInRadians.Value*Mathf.Rad2Deg;
		}
	}
}