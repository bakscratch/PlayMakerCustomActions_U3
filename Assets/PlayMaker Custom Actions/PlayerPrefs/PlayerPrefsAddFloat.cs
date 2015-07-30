// (c) Copyright HutongGames, LLC 2010-2015. All rights reserved.
// Action made by DjayDino
/*--- __ECO__ __ACTION__ ---*/
// @keyword: playerpref player pref preference

using UnityEngine;
namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("PlayerPrefs")]
	[Tooltip("Adds a value to a playerprefs float identified by key. WARNING!! use PlayerPrefs only at key moments")]
	public class PlayerPrefsAddFloat : FsmStateAction
	{
		[Tooltip("Case sensitive key.")]
		public FsmString key;
		public FsmFloat add;
		private FsmFloat variables;

		public override void Reset()
		{
			key = "";
			variables = new FsmFloat();
			add = null;
		}

		public override void OnEnter()
		{
				if(!key.IsNone || !key.Value.Equals(""))  
				variables.Value = PlayerPrefs.GetFloat(key.Value, variables.IsNone ? 0f : variables.Value);
				
				variables.Value += add.Value;
				
				PlayerPrefs.SetFloat(key.Value, variables.IsNone ? 0f : variables.Value);

			Finish();
		}

	}
}
