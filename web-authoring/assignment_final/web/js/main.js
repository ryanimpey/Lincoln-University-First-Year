//Make sure page has loaded before executing js
$( document ).ready(function() {
    $('.nav-menu-opener').click(function(){
      $('.hidden-sidenav').fadeToggle();
    })

    $('.nav-menu-closer').click(function(){
      $('.hidden-sidenav').fadeToggle();
    })

    $('.cart-toggle').click(function(){
      $('.cart-sidenav').fadeToggle();
    })

    $('.cart-menu-closer').click(function(){
      $('.cart-sidenav').fadeToggle();
    })

    var arrayToIterate;
    window['arrayValue'] = 0;

    $('#bentley-small').click(function(){
      $('.car-customisation-text').text('Bentley Customisation');
      $('.preview-image').css('background', 'url("./img/cars/bentley/bentleyred.jpg")');
      arrayToIterate = 'bentley';
      $('.selected-product-title').text(" ");
      $('.selected-product-price').text(" ");
    });

    $('#lam-small').click(function(){
      $('.car-customisation-text').text('Lamborghini Customisation');
      $('.preview-image').css('background', 'url("./img/cars/lamborghini/lamborghiniyellow.jpg")');
      arrayToIterate = 'lam';
      $('.selected-product-title').text(" ");
      $('.selected-product-price').text(" ");
    });

    $('#bmw-small').click(function(){
      $('.car-customisation-text').text('BMW Customisation');
      $('.preview-image').css('background', 'url("./img/cars/bmw/bmwblue.jpg")');
      arrayToIterate = 'bmw';
      $('.selected-product-title').text(" ");
      $('.selected-product-price').text(" ");
    });

    $('#boris-small').click(function(){
      $('.car-customisation-text').text('Boris Bike - Default');
      $('.preview-image').css('background', 'url("./img/cycles/boris.png")');
      arrayToIterate = 'boris';
      $('.selected-product-title').text(" ");
      $('.selected-product-price').text(" ");
    });

    $('#mountain-small').click(function(){
      $('.car-customisation-text').text('Mountain Bike Customisation');
      $('.preview-image').css('background', 'url("./img/cycles/mountain-bike/bikeblack.jpg")');
      arrayToIterate = 'mountain';
      $('.selected-product-title').text(" ");
      $('.selected-product-price').text(" ");
    });

    $('#racecycle-small').click(function(){
      $('.car-customisation-text').text('Race Bike - Default');
      $('.preview-image').css('background', 'url("./img/cycles/race-bike.jpg")');
      arrayToIterate = 'racecycle';
      $('.selected-product-title').text(" ");
      $('.selected-product-price').text(" ");
    });

    $('#yamaha-small').click(function(){
      $('.car-customisation-text').text('Motorbike - Yamaha');
      $('.preview-image').css('background', 'url("./img/bikes/black.jpg")');
      arrayToIterate = 'yamaha';
      $('.selected-product-title').text(" ");
      $('.selected-product-price').text(" ");
    });

    $('.place-order').click(function(){
      alert("Order has been placed! Thank you for your custom");
      localStorage.removeItem("selectedProducts");
    })

    $('.previous-button').click(function(){
      switch(arrayToIterate){
        case "bentley":
          changeImageBack(bentleyImageList, arrayValue);
          break;
        case "lam":
          changeImageBack(lamborghiniImageList, arrayValue);
          break;
        case "bmw":
          changeImageBack(bmwImageList, arrayValue);
          break;
        case "boris":
          changeImageBack(borisImageList, arrayValue);
          break;
        case "mountain":
          changeImageBack(mountainImageList, arrayValue);
          break;
        case "racecycle":
          changeImageBack(racecycleImageList, arrayValue);
          break;
        case "yamaha":
          changeImageBack(yamahaImageList, arrayValue);
          break;
      }
    })

    $('.next-button').click(function(){
      switch(arrayToIterate){
        case "bentley":
          changeImageForward(bentleyImageList, arrayValue);
          break;
        case "lam":
          changeImageForward(lamborghiniImageList, arrayValue);
          break;
        case "bmw":
          changeImageForward(bmwImageList, arrayValue);
          break;
        case "boris":
          changeImageForward(borisImageList, arrayValue);
          break;
        case "mountain":
          changeImageForward(mountainImageList, arrayValue);
          break;
        case "racecycle":
          changeImageForward(racecycleImageList, arrayValue);
          break;
        case "yamaha":
          changeImageForward(yamahaImageList, arrayValue);
          break;
      }
    })

    function changeImageBack(item, arrayValue){
      if(window['arrayValue'] !== 0){
        window['arrayValue'] = window['arrayValue']-1;
        $('.preview-image').css('background', 'url('+item[window['arrayValue']].url + ')');
        $('.selected-product-title').text(item[window['arrayValue']].name);
        $('.selected-product-price').text(item[window['arrayValue']].price);
      }else{
        window['arrayValue'] = item.length-1;
        $('.preview-image').css('background', 'url('+item[window['arrayValue']].url + ')');
        $('.selected-product-title').text(item[window['arrayValue']].name);
        $('.selected-product-price').text(item[window['arrayValue']].price);
      }
    }

    function changeImageForward(item, arrayValue){
      if(window['arrayValue'] == item.length-1){
        window['arrayValue'] = 0;
        $('.preview-image').css('background', 'url('+item[window['arrayValue']].url + ')');
        $('.selected-product-title').text(item[window['arrayValue']].name);
        $('.selected-product-price').text(item[window['arrayValue']].price);
      } else{
        window['arrayValue'] = window['arrayValue']+1;
        $('.preview-image').css('background', 'url('+item[window['arrayValue']].url + ')');
        $('.selected-product-title').text(item[window['arrayValue']].name);
        $('.selected-product-price').text(item[window['arrayValue']].price);
      }
    }

    var productList = [
      {name: "Cars", background: "./img/product-images/cars.jpg", url: "cars"},
      {name: "Cycles", background: "./img/product-images/cycle.jpg", url: "cycles"},
      {name: "Motorcycles", background: "./img/product-images/motorcycles.jpg", url: "bikes"},
      {name: "Boats", background: "./img/product-images/boat.jpg", url: "boats"},
      {name: "Planes", background: "./img/product-images/plane.jpg", url: "planes"},
    ]

    var bentleyImageList = [
      {name: "Bentley - Red", url: "./img/cars/bentley/bentleyred.jpg", price: "£140300"},
      {name: "Bentley - Blue", url: "./img/cars/bentley/bentleyblue.jpg", price: "£145000"},
      {name: "Bentley - Green", url: "./img/cars/bentley/bentleygreen.jpg", price: "£13500"},
      {name: "Bentley - Purple", url: "./img/cars/bentley/bentleypurple.jpg", price: "£125999"}
    ]

    var lamborghiniImageList = [
      {name: "Lamborghini - Blue", url: "./img/cars/lamborghini/lamborghiniblue.jpg", price: "£200000"},
      {name: "Lamborghini - Green", url: "./img/cars/lamborghini/lamborghinigreen.jpg", price: "£204999"},
      {name: "Lamborghini - Orange", url: "./img/cars/lamborghini/lamborghiniorange.jpg", price: "£199999"},
      {name: "Lamborghini - Purple", url: "./img/cars/lamborghini/lamborghinipurple.jpg", price: "£189999"},
      {name: "Lamborghini - Yellow", url: "./img/cars/lamborghini/lamborghiniyellow.jpg", price: "£209999"}
    ]

    var bmwImageList = [
      {name: "BMW - Red", url: "./img/cars/bmw/bmwred.jpg", price: "£39999"},
      {name: "BMW - Blue", url: "./img/cars/bmw/bmwblue.jpg", price: "£34999"},
      {name: "BMW - Green", url: "./img/cars/bmw/bmwgreen.jpg", price: "£24999"},
      {name: "BMW - Purple", url: "./img/cars/bmw/bmwpurple.jpg", price: "£29999"}
    ]

    var borisImageList = [
      {name: "Boris Bike", url: "./img/cycles/boris.png", price: "£250"}
    ]

    var mountainImageList = [
      {name: "Mountain Bike - Black", url: "./img/cycles/mountain-bike/bikeblack.jpg", price:"£999"},
      {name: "Mountain Bike - Blue", url: "./img/cycles/mountain-bike/bikeblue.jpg", price:"£949"},
      {name: "Mountain Bike - Purple", url: "./img/cycles/mountain-bike/bikepurple.jpg", price:"£899"}
    ]

    var racecycleImageList = [
      {name: "Race Bike - Standard", url: "./img/cycles/race-bike.jpg", price:"£2499"}
    ]

    var yamahaImageList = [
      {name: "Yamaha - Black", url: "./img/bikes/black.jpg", price:"£8999"},
      {name: "Yamaha - Blue", url: "./img/bikes/blue.jpg", price:"£4999"},
      {name: "Yamaha - White & Blue", url: "./img/bikes/bluewhite.jpg", price:"£4599"}
    ]



    if ($('#product-holder-products').length){
        for (var i = 0; i < productList.length; i++) {
          $('#product-holder-products').append("<a href='"+ productList[i].url +".html'> <div class='product-container' style='background: url(" + productList[i].background +")'><div class='product-sidebar-text product-overlay-text white open-sans'><h1>" + productList[i].name + "</h1></div></div></a>")
        }
    }

    var isIE11 = !!window.MSInputMethodContext && !!document.documentMode;
    if(isIE11){
      $("head").append("<link href='./css/internet_explorer.css' rel='stylesheet'>");
    }

    var data = {"total":0,"rows":[]};
    var totalCost = 0;

    $(function(){
      $('#cartcontent').datagrid({
        singleSelect:true
      });
    $('.item').draggable({
        revert:true,
        proxy:'clone',
        onStartDrag:function(){
            $(this).draggable('options').cursor = 'not-allowed';
            $(this).draggable('proxy').css('z-index',10);
        },
        onStopDrag:function(){
            $(this).draggable('options').cursor='move';
        }
    });

    $('.cart-sidenav').droppable({
        onDragEnter:function(e,source){
            $(source).draggable('options').cursor='auto';
        },
        onDragLeave:function(e,source){
            $(source).draggable('options').cursor='not-allowed';
        },
        onDrop:function(e,source){
            var name = $(source).children().eq(0).text();
            var price = $(source).children().eq(1).text();
            addProduct(name, parseFloat(price.split('£')[1]));
        }
    });
    		});
    function addProduct(name,price){
        function add(){
            for(var i=0; i<data.total; i++){
                var row = data.rows[i];
                if (row.name == name){
                    row.quantity += 1;
                    return;
                }
            }
            data.total += 1;
            data.rows.push({
                name:name,
                quantity:1,
                price:price
            });
            console.log(data.rows);
        }
        add();
        totalCost += price;
        $('#cartcontent').datagrid('loadData', data);
        $('.total').html('Total: £'+totalCost);

        productArrayJSON.push({itemName:name, itemPrice:price});
        productArrayString = JSON.stringify(productArrayJSON);
        localStorage.setItem("selectedProducts", productArrayString);
        console.log(localStorage.selectedProducts)


    }

    var productArrayJSON;
    if(localStorage.selectedProducts == undefined){
      productArrayJSON = [];
    } else{
      productArrayJSON = JSON.parse(localStorage.selectedProducts);
    }
    var productArrayString = JSON.stringify(productArrayJSON);

    //Local Storage Retrieval
    if(localStorage.selectedProducts != undefined){
      var productArrayReturned = JSON.parse(localStorage.selectedProducts);
      var savedProducts = [];
      var totalSaved = 0;
      for(var i = 0; i < productArrayReturned.length;i++){
        savedProducts.push({name: productArrayReturned[i].itemName, price: productArrayReturned[i].itemPrice})
        totalSaved += productArrayReturned[i].itemPrice;
        $('#previous-cart-append').append("<tr><td>" + productArrayReturned[i].itemName + "</td><td>1</td><td>" + productArrayReturned[i].itemPrice + "</td></tr>")
      }
      $('#cartTotal').html('Total: £'+ totalSaved);
    }

    //Check support
    if (typeof(Storage) !== "undefined") {
    console.log("Local storage is enabled!");
  } else {
    alert('This browser seems to be having local storage issues, and so your cart may not be saved');
    console.log("Local storage is not working on this browser, sorry!");
  }
});
