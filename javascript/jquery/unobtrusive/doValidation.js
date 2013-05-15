var form = $('#MyForm');
$.validator.unobtrusive.parse(form);
if (form.valid()) {
	console.log('Valid values');
}
else{
	console.log('Found some invalid values');
}
