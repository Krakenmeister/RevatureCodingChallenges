using System;
using System.Collections;
using System.Collections.Generic;
namespace CharMode {
	class CharMode {
		public static string maxOccur (string text) {
			List<char> characters = new List<char>();
			List<int> characterCounts = new List<int>();
			for (int i=0; i<text.Length; i++) {
				bool newChar = true;
				for (int j=0; j<characters.Count; j++) {
					if (characters[j] == text[i]) {
						newChar = false;
						characterCounts[j] = characterCounts[j] + 1;
					}
				}
				if (newChar) {
					characters.Add(text[i]);
					characterCounts.Add(1);
				}
			}
			int maxCount = 0;
			for (int i=0; i<characterCounts.Count; i++) {
				if (characterCounts[i] > maxCount) {
					maxCount = characterCounts[i];
				}
			}
			if (maxCount < 2) {
				return "No Repetition";
			}
			string mode = "";
			for (int i=0; i<characterCounts.Count; i++) {
				if (characterCounts[i] == maxCount) {
					if (mode.Length != 0) {
						mode += ", ";
					}
					mode += Char.ToString(characters[i]);
				}
			}
			return mode;
		}

		public static void Main (string[] args) {
			System.Console.WriteLine(maxOccur("Computer Science"));
			System.Console.WriteLine(maxOccur("Edabit"));
			System.Console.WriteLine(maxOccur("system admin"));
			System.Console.WriteLine(maxOccur("the quick brown fox jumps over the lazy dog"));
		}
	}      
}
