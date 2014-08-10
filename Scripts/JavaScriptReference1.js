$(function () {
    //alert('Hiii Adi');
});

$(".data-change").change(function () {
    var element = $(this);
    element.toggleClass('data-change',!( element.val().length > 0 && element.val() != '--Select--'));
});
/*
// F Y Reference....

$( "#foo" ).toggleClass( className, addOrRemove );

is equivalent to:

if ( addOrRemove ) {
  $( "#foo" ).addClass( className );
} else {
  $( "#foo" ).removeClass( className );
}
*/

$(".data-change_back").change(function () {
    var element = $(this);
    if (element.val().length > 0 && element.val() != '--Select--') {
        element.removeClass('data-change').addClass('data-change-no-color');
    }
    else {
        element.removeClass('data-change-no-color').addClass('data-change');
    }
});