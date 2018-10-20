using System;
using System.Collections;
using System.Collections.Generic;

public class Stacks {

	List<String> list = new List<string> ();

	public void Push (string element) {
		list.Add (element);
	}

	public void Pop () {
		list.RemoveAt (list.Count);
	}

	public string Peek () {
		return list.Count.ToString ();
	}
}