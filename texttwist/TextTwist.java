public class TextTwist {
	public static int score (String[] words, String word) {
		int totalScore = 0;
		for (int i=0; i<words.length; i++) {
			StringBuilder wordCopy = new StringBuilder(String.valueOf(word));
			boolean validWord = true;
			for (int j=0; j<words[i].length(); j++) {
				if (wordCopy.indexOf(Character.toString(words[i].charAt(j))) == -1) {
					validWord = false;
					break;
				} else {
					wordCopy.deleteCharAt(wordCopy.indexOf(Character.toString(words[i].charAt(j))));
				}
			}
			if (validWord) {
				if (words[i].length() >= 3) {
					totalScore += (words[i].length() - 2);
				}
				if (words[i].length() == 6) {
					totalScore += 50;
				}
			}
		}
		return totalScore;
	}

	public static void main (String[] args) {
		String[] words1 = new String[]{"cat", "create", "sat"};
		String[] words2 = new String[]{"trance", "recant"};
		String[] words3 = new String[]{"dote", "dotes", "toes", "set", "dot", "dots", "sted"};
		System.out.println(score(words1, "caster"));
		System.out.println(score(words2, "recant"));
		System.out.println(score(words3, "tossed"));
//		System.out.println(score(["trance", "recant"], "recant"));
//		System.out.println(score(["dote", "dotes", "toes", "set", "dot", "dots", "sted"], "tossed"));
	}
}
