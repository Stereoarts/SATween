// Copyright (c) 2016 Nora
// Released under the MIT license
// http://opensource.org/licenses/mit-license.php
//
// Reference from "Robert Penner's Easing Functions"
// http://robertpenner.com/easing/

using UnityEngine;

namespace SA
{
	public class TweenSample : MonoBehaviour
	{
		public enum Function {
			Linear,
			SquaricEaseIn,
			SquaricEaseOut,
			SquaricEaseInOut,
			CubicEaseIn,
			CubicEaseOut,
			CubicEaseInOut,
		}

		public Function function;

		public bool isEasing = false;
		public float fromValue = 0.0f;
		public float toValue = 10.0f;
		public float timeScaler = 1.0f;

		float elapsedTime = 0.0f;

#if UNITY_EDITOR
		void Update()
		{
			if( !isEasing ) {
				return;
			}

			float v = 0.0f;

			switch( function ) {
			case Function.Linear:
				v = Tween.Math.Linear( fromValue, toValue, elapsedTime );
				break;
			case Function.SquaricEaseIn:
				v = Tween.Math.SquaricEaseIn( fromValue, toValue, elapsedTime );
				break;
			case Function.SquaricEaseOut:
				v = Tween.Math.SquaricEaseOut( fromValue, toValue, elapsedTime );
				break;
			case Function.SquaricEaseInOut:
				v = Tween.Math.SquaricEaseInOut( fromValue, toValue, elapsedTime );
				break;
			case Function.CubicEaseIn:
				v = Tween.Math.CubicEaseIn( fromValue, toValue, elapsedTime );
				break;
			case Function.CubicEaseOut:
				v = Tween.Math.CubicEaseOut( fromValue, toValue, elapsedTime );
				break;
			case Function.CubicEaseInOut:
				v = Tween.Math.CubicEaseInOut( fromValue, toValue, elapsedTime );
				break;
			}

			var localPosition = transform.localPosition;
			localPosition.x = v;
			transform.localPosition = localPosition;

			if( elapsedTime >= 1.0f - float.Epsilon ) {
				isEasing = false;
				elapsedTime = 0.0f;
            } else {
				elapsedTime += Time.deltaTime * timeScaler;
				if( elapsedTime > 1.0f ) {
					elapsedTime = 1.0f;
				}
			}
		}

		void OnEnable()
		{
		}

		void OnDisable()
		{
		}
#endif
	}
}

