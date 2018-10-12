using System;

public static class SelectionSort {

	public static void Sort (int [] array) {
		int minIndex, minValue;

		for (int start = 0; start < array.Length - 1; start++) {
			minIndex = start;
			minValue = array [start];

			for (int index = start + 1; index < array.Length; index++) {
				if (array [index] < minValue) {
					minValue = array [index];
					minIndex = index;
				}
			}

			Swap (ref array [minIndex], ref array [start]);
		}
	}

	static void Swap (ref int a, ref int b) {
		int temp = a;
		a = b;
		b = temp;
	}


}