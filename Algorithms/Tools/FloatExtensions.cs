using System;

public static class FloatExtensions {
	const float _3 = 0.001f;
	const float _4 = 0.0001f;
	const float _5 = 0.00001f;
	const float _6 = 0.000001f;
	const float _7 = 0.0000001f;

	public static bool Equals3DigitPrecision (this float left, float right) {
		return Math.Abs (left - right) < _3;
	}

	public static bool Equals4DigitPrecision (this float left, float right) {
		return Math.Abs (left - right) < _4;
	}

	public static bool Equals5DigitPrecision (this float left, float right) {
		return Math.Abs (left - right) < _5;
	}

	public static bool Equals6DigitPrecision (this float left, float right) {
		return Math.Abs (left - right) < _6;
	}

	public static bool Equals7DigitPrecision (this float left, float right) {
		return Math.Abs (left - right) < _7;
	}

}
