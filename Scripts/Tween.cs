// Copyright (c) 2016 Nora
// Released under the MIT license
// http://opensource.org/licenses/mit-license.php
//
// Reference from "Robert Penner's Easing Functions"
// http://robertpenner.com/easing/

using UnityEngine;

namespace SA
{
	public static class Tween
	{
		public static class Math
		{
			//----------------------------------------------------------------------------------------------------

			public static float Linear( float a, float b, float r )
			{
				return a + (b - a) * r;
			}

			public static Vector2 Linear( Vector2 a, Vector2 b, float r )
			{
				return new Vector2(
					a.x + (b.x - a.x) * r,
					a.y + (b.y - a.y) * r );
			}

			public static Vector3 Linear( Vector3 a, Vector3 b, float r )
			{
				return new Vector3(
					a.x + (b.x - a.x) * r,
					a.y + (b.y - a.y) * r,
					a.z + (b.z - a.z) * r );
			}

			//----------------------------------------------------------------------------------------------------

			public static float SquaricEaseIn( float a, float b, float r )
			{
				return a + (b - a) * r * r;
			}

			public static Vector2 SquaricEaseIn( Vector2 a, Vector2 b, float r )
			{
				r = r * r;
				return new Vector2(
					a.x + (b.x - a.x) * r,
                    a.y + (b.y - a.y) * r );
			}

			public static Vector3 SquaricEaseIn( Vector3 a, Vector3 b, float r )
			{
				r = r * r;
				return new Vector3(
					a.x + (b.x - a.x) * r,
					a.y + (b.y - a.y) * r,
					a.z + (b.z - a.z) * r );
			}

			//----------------------------------------------------------------------------------------------------

			public static float SquaricEaseOut( float a, float b, float r )
			{
				r = 1.0f - r;
				return b + (a - b) * r * r;
			}

			public static Vector2 SquaricEaseOut( Vector2 a, Vector2 b, float r )
			{
				r = 1.0f - r;
				r = r * r;
				return new Vector2(
					b.x + (a.x - b.x) * r,
					b.y + (a.y - b.y) * r );
            }

			public static Vector3 SquaricEaseOut( Vector3 a, Vector3 b, float r )
			{
				r = 1.0f - r;
				r = r * r;
				return new Vector3(
					b.x + (a.x - b.x) * r,
					b.y + (a.y - b.y) * r,
					b.z + (a.z - b.z) * r );
			}

			//----------------------------------------------------------------------------------------------------

			public static float SquaricEaseInOut( float a, float b, float r )
			{
				if( r < 0.5f ) {
					r = r * 2.0f;
					return a + (b - a) * 0.5f * r * r;
				} else {
					r = 1.0f - (r - 0.5f) * 2.0f;
					return b + (a - b) * 0.5f * r * r;
				}
			}

			public static Vector2 SquaricEaseInOut( Vector2 a, Vector2 b, float r )
			{
				if( r < 0.5f ) {
					r = r * 2.0f;
					r = r * r;
					r = r * 0.5f;
					return new Vector2(
						a.x + (b.x - a.x) * r,
						a.y + (b.y - a.y) * r );
				} else {
					r = 1.0f - (r - 0.5f) * 2.0f;
					r = r * r;
					return new Vector2(
						b.x + (a.x - b.x) * r,
						b.y + (a.y - b.y) * r );
				}
			}

			public static Vector3 SquaricEaseInOut( Vector3 a, Vector3 b, float r )
			{
				if( r < 0.5f ) {
					r = r * 2.0f;
					r = r * r;
					r = r * 0.5f;
					return new Vector3(
						a.x + (b.x - a.x) * r,
						a.y + (b.y - a.y) * r,
						a.z + (b.z - a.z) * r );
				} else {
					r = 1.0f - (r - 0.5f) * 2.0f;
					r = r * r;
					r = r * 0.5f;
					return new Vector3(
						b.x + (a.x - b.x) * r,
						b.y + (a.y - b.y) * r,
						b.z + (a.z - b.z) * r );
				}
			}

			//----------------------------------------------------------------------------------------------------

			public static float CubicEaseIn( float a, float b, float r )
			{
				return a + (b - a) * r * r * r;
			}

			public static Vector2 CubicEaseIn( Vector2 a, Vector2 b, float r )
			{
				r = r * r * r;
				return new Vector2(
					a.x + (b.x - a.x) * r,
					a.y + (b.y - a.y) * r );
			}

			public static Vector3 CubicEaseIn( Vector3 a, Vector3 b, float r )
			{
				r = r * r * r;
				return new Vector3(
					a.x + (b.x - a.x) * r,
					a.y + (b.y - a.y) * r,
					a.z + (b.z - a.z) * r );
			}

			//----------------------------------------------------------------------------------------------------

			public static float CubicEaseOut( float a, float b, float r )
			{
				r = 1.0f - r;
				return b + (a - b) * r * r * r;
			}

			public static Vector2 CubicEaseOut( Vector2 a, Vector2 b, float r )
			{
				r = 1.0f - r;
				r = r * r * r;
				return new Vector2(
					b.x + (a.x - b.x) * r,
					b.y + (a.y - b.y) * r );
			}

			public static Vector3 CubicEaseOut( Vector3 a, Vector3 b, float r )
			{
				r = 1.0f - r;
				r = r * r * r;
				return new Vector3(
					b.x + (a.x - b.x) * r,
					b.y + (a.y - b.y) * r,
					b.z + (a.z - b.z) * r );
			}

			//----------------------------------------------------------------------------------------------------

			public static float CubicEaseInOut( float a, float b, float r )
			{
				if( r < 0.5f ) {
					r = r * 2.0f;
					return a + (b - a) * 0.5f * r * r * r;
				} else {
					r = 1.0f - (r - 0.5f) * 2.0f;
					return b + (a - b) * 0.5f * r * r * r;
				}
			}

			public static Vector3 CubicEaseInOut( Vector3 a, Vector3 b, float r )
			{
				if( r < 0.5f ) {
					r = r * 2.0f;
					r = r * r * r;
					r = r * 0.5f;
					return new Vector3(
						a.x + (b.x - a.x) * r,
						a.y + (b.y - a.y) * r,
						a.z + (b.z - a.z) * r );
				} else {
					r = 1.0f - (r - 0.5f) * 2.0f;
					r = r * r * r;
					r = r * 0.5f;
					return new Vector3(
						b.x + (a.x - b.x) * r,
						b.y + (a.y - b.y) * r,
						b.z + (a.z - b.z) * r );
				}
			}

		}
	}
}
