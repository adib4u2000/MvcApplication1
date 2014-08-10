$(function () {
    //alert('Hiii Javascript Reference 2');
});

//Check the parent check box
$(".chkParent").click(function () {
    $('.chkChild').attr("checked", this.checked);
});

$(".chkChild").click(function () {
    if ($('.chkChild').length != $(".chkChild:checked").length)
        $(".chkParent").removeAttr("checked");
    else
        $(".chkParent").attr("checked", "checked");
});