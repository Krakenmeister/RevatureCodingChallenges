function additivePersistence (n) {
	var counter = 0;
	while (n > 9) {
		var digits = n.toString();
		n = 0;
		for (var i=0; i<digits.length; i++) {
			n += parseInt(digits.charAt(i));
		}
		counter++;
	}
	return counter;
}

function multiplicativePersistence (n) {
	var counter = 0;
	while (n > 9) {
		var digits = n.toString();
		n = 1;
		for (var i=0; i<digits.length; i++) {
			n *= parseInt(digits.charAt(i));
		}
		counter++;
	}
	return counter;
}

console.log(additivePersistence(1679583))
console.log(additivePersistence(123456))
console.log(additivePersistence(6))
console.log(multiplicativePersistence(77))
console.log(multiplicativePersistence(123456))
console.log(multiplicativePersistence(4))
