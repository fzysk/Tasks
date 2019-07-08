// 01 Optional Power
function optionalPow(a, b) {
	var result = confirm("Do you agree with this question?");
	
	if (result) return Math.pow(a, b);
	else return Math.pow(b, a);
}

// 02 Fix Age
function fixage(arr) {
	var result = '';
	
	arr.forEach(function(a) {
		if (a >= 18 && a <= 60) {
			result += a + ", ";
		}
	});

	result.substr(0, result.length - 2);
}