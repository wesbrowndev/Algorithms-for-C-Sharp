using System;

public static class BubbleSort {

	public static void Sort (int [] array) {
		for (int maxElement = array.Length - 1; maxElement > 0; maxElement--) {
			for (int index = 0; index < maxElement; index++) {
				if (array [index] > array [index + 1]) {
					Swap (ref array [index], ref array [index + 1]);
				}
			}
		}
	}

	static void Swap (ref int a, ref int b) {
		int temp = a;
		a = b;
		b = temp;
	}

}