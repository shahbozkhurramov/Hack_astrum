function ButtonClick(tab) {
    document.getElementById(tab).click();
}
function changeSelectedLanguage(lan){
  var select = document.getElementById('selectLanguage');
  var option;
  console.log(lan);
  for (var i=0; i<select.options.length; i++) {
  option = select.options[i];
  if (option.value == lan) {
      option.setAttribute('selected', true);
      return; 
  } 
  }
}

function FormInputValidation(){
    let empty = false;
    $('.form-control').each(function() {
        if ($(this).val() === "") {
          empty = true;
        }
    });
    if (empty) {
      $('#SendButton').attr('disabled', 'disabled');
    } else{
        $('#SendButton').removeAttr('disabled');
    }
}
  
  function StopVideo(){
    $('#exampleModal').on('hidden.bs.modal', function () {
        $("#exampleModal iframe").attr("src", $("#exampleModal iframe").attr("src"));
    });
  }

window.onscroll = function() {scrollFunction()};

function scrollFunction() {
  $(window).scroll(function () {
    if($(window).scrollTop() > 150) {
      $('#navcollapseAll').css('position', 'fixed');
      $('#navcollapseAll').css('right', 0);
      $('#navcollapseAll').css('left', 0);
      $('#navcollapseAll').css('top', 0);
    } else {
    $('#navcollapseAll').css('position', '');
    $('#navcollapseAll').css('background-color', 'white');
      $('#navcollapseAll').css('top', '-100%');
    }
  });
}

