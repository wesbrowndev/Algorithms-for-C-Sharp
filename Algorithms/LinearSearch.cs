using System;

public static class LinearSearch {

	public static int Search (int [] array, int value) {
		int index = 0;
		int position = -1;
		bool found = false;

		while (index < array.Length && !found) {
			if (array [index] == value) {
				found = true;
				position = index;
			}

			index++;
		}

		return position;
	}

	public static int Search (float [] array, float value)
	{
		int index = 0;
		int position = -1;
		bool found = false;

		while (index < array.Length && !found) {
			if (array [index].Equals7DigitPrecision (value)) {
				found = true;
				position = index;
			}

			index++;
		}

		return position;
	}

	public static int Search (string [] array, string value)
	{
		int index = 0;
		int position = -1;
		bool found = false;

		while (index < array.Length && !found) {
			if (array [index] == value) {
				found = true;
				position = index;
			}

			index++;
		}

		return position;
	}
}
