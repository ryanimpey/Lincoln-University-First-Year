$('.circular-shop').click(function(){
  $('html, body').animate({
        scrollTop: $(".section-products-title").offset().top
    }, 300);
});

var bgImageList = [
  'https://img-new.cgtrader.com/items/36548/dc4c32cd9a/bmw-6-series-white-wireframe-car-3d-model-obj.jpg',
  'http://poonamkanekar.weebly.com/uploads/2/5/0/7/25075031/9794240_orig.jpg',
  'https://s-media-cache-ak0.pinimg.com/originals/30/56/15/305615f971ea4f79cabd9f2956672ce1.jpg',
  'http://previews.123rf.com/images/podsolnukh/podsolnukh1407/podsolnukh140700340/29988735-luxury-motor-yacht-3D-model-body-structure-wire-model-Stock-Photo.jpg',
  'http://www.3dcadbrowser.com/th/1/1/1066.jpg'
]

window.onload = function(){
  var allButtons = document.getElementsByClassName("circular-shop");
      
      for(var i = 0; i < allButtons.length; i++)
      {
        //Iterate through each button, store it locally for the sake of brevity:
        var button = allButtons[i];
        
        //And add a listener.. in this case, we will be passing the mouse data so we know which button we have pressed.
        button.addEventListener("click", function(mouseData)
        {
          //And when we click the button, we will call a function with the text of this button, so we can use
          //it in the calculator's logic.
          onShopButtonClicked(mouseData.target);
        });
      }
} 

function onShopButtonClicked(value){
        //console.log(value.id);
        var selectedOption = value.id;
        //console.log(selectedOption.substring(9, selectedOption.length));
        selectedOption = selectedOption.substring(9, selectedOption.length)

        switch(selectedOption){
          case "car":
            $('.section-custom-left').css('background-image', "url(" + bgImageList[0] + ")");
            console.log(bgImageList[0]);
            break;
          case "cycle":
            $('.section-custom-left').css('background-image', "url(" + bgImageList[1] + ")");
            console.log(bgImageList[1]);
            break;
          case "motorcycle":
            $('.section-custom-left').css('background-image', "url(" + bgImageList[2] + ")");
            console.log(bgImageList[2]);
            break;
          case "boat":
            $('.section-custom-left').css('background-image', "url(" + bgImageList[3] + ")");
            console.log(bgImageList[3]);
            break;
          case "plane":
            $('.section-custom-left').css('background-image', "url(" + bgImageList[4] + ")");
            console.log(bgImageList[4]);
            break;
        }

      }
