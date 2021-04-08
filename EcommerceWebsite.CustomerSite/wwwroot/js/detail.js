function SetImage(url) {
	console.log(url)
	$("#ProductImage").attr("src", url);
}
var quantitiy = 0;

function Plus() {
    //e.preventDefault();
    var quantity = parseInt($('#quantity').val());
    //document.getElementById("quantity").innerHTML = "" + quantity;
    $('#quantity').val(quantity + 1); 
}

function Minus() {
    //e.preventDefault();
    var quantity = parseInt($('#quantity').val());
    if (quantity > 0) {
        $('#quantity').val(quantity - 1);
    }
}