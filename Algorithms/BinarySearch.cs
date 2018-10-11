using System;

public static class BinarySearch {
	public static int Search (int [] array, int value) {
		int first = 0;
		int last = array.Length - 1;
		int middle;
		int position = -1;
		bool found = false;

		while (!found && first <= last) {
			middle = (first + last) / 2;

			if (array[middle] == value) {
				found = true;
				position = middle;
			} else if (array[middle] > value) {
				last = middle - 1;
			} else {
				first = middle + 1;
			}
		}

		return position;
	}

	public static int Search (float [] array, float value) {
		int first = 0;
		int last = array.Length - 1;
		int middle;
		int position = -1;
		bool found = false;

		while (!found && first <= last) {
			middle = (first + last) / 2;

			if (array [middle].Equals7DigitPrecision(value)) {
				found = true;
				position = middle;
			} else if (array [middle] > value) {
				last = middle - 1;
			} else {
				first = middle + 1;
			}
		}

		return position;
	}
}
