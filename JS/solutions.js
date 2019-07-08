// Optional Power
function optionalPow(a, b) {
	var result = confirm("Do you agree with this question?");
	
	if (result) return Math.pow(a, b);
	else return Math.pow(b, a);
}