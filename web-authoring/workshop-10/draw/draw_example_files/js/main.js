var mousePressed = false;
var lastX, lastY, my_context;

var selcolourVal = "#000000";
var selwidthVal = 1
var texture;
var canvas;
var crayonTextureImage = new Image();
crayonTextureImage.src = "assets/crayon-texture.png";
var crayon = false;

function Init() {
	//get all elements and and assignt to var
	
	//get canvas and .getContext("2d");

	// mouse events for changes in input fields
    texture.addEventListener("change", (function(e) {
        if (texture.checked == false) {
            //crayon = false;
        } else {
            //crayon = true;
        }
    }));
	
	// get stroke width from input
   
	
	// get colour from html colour input
    
	//clear area event listener
    clearBtn.addEventListener("click", (function(e) {
        

    }));
	
	//mouse down

    canvas.addEventListener("mousedown", (function(e) {
        mousePressed = true;
        Draw(e.pageX - this.offsetLeft, e.pageY - this.offsetTop, false);
    }));

    //mouse move
	// check if mouse pressed
                
  
	
	//mouse mouseup
   
	
	//mouseleave
    canvas.addEventListener("mouseleave", (function(e) {
        mousePressed = false;
    }));
}

function Draw(x, y, isDown) {

    if (isDown) {
        //check if image is to draw on canvas
    }
	//must upate lastx and y to use for move to and line to
    lastX = x;
    lastY = y;
}

function clearArea() {
    // Use the identity matrix while clearing the canvas
    my_context.clearRect(0, 0, my_context.canvas.width, my_context.canvas.height);
}

window.onload = function()
{
	console.log('loaded');
	Init();
}