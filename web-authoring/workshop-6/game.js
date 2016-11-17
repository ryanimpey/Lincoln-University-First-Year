//All the images of different heads.
var headImages = 
[
	"images/head/robot1-head.png", 
	"images/head/robot2-head.png", 
	"images/head/robot3-head.png",
	"images/head/robot-head-tophat.png",
	"images/head/robot-head-sombrero.png",
	"images/head/robot-head-sunglasses.png"
];

//All the images of different torsos.
var torsoImages = 
[
	"images/torso/robot1-torso.png", 
	"images/torso/robot2-torso.png",
	"images/torso/robot3-torso.png",
	"images/torso/torso-up-black.png",
	"images/torso/torso-up-blue.png",
	"images/torso/torso-up-red.png",
	"images/torso/torso-down-black.png",
	"images/torso/torso-down-blue.png",
	"images/torso/torso-down-red.png",
	"images/torso/torso-down-uol-blue.png",
	"images/torso/torso-down-uol-black.png",
	"images/torso/torso-down-html5-blue.png",
	"images/torso/torso-down-html5-green.png"
];

//All the images of different legs.
var legsImages = 
[
	"images/legs/robot2-legs.png", 
	"images/legs/robot3-legs.png", 
	"images/legs/robot-legs-blue.png", 
	"images/legs/robot-legs-black.png"
];

//Each index for the head, torso and legs of this 'person'.
var headIndex, torsoIndex, legsIndex;

//Set them all to 0 initially.
headIndex = torsoIndex = legsIndex = 0;

//The current head, torso and legs elements. We will change the image of these elements.
var headImage, torsoImage, legsImage;

//Track saves made
var changeTracker = 0;

/**
 * Called when the page first loads.
*/
window.onload = function()
{
	//Get each element for the head, torso and legs.
	headImage  = document.getElementById("head-image");
	torsoImage = document.getElementById("torso-image");
	legsImage  = document.getElementById("legs-image");
	changeTracker = localStorage.getItem("changeTracker");
	document.getElementById("changeCount").innerHTML = changeTracker;
  //Set images initially
	onBodyChanged();
}


/**
 * Called when the user clicks the "randomize" button. 
*/
function randomizeBody()
{
	var randomHead = Math.floor(Math.random() * headImages.length);
  var randomTorso = Math.floor(Math.random() * torsoImages.length);
  var randomLegs = Math.floor(Math.random() * legsImages.length);
	headImage.src = headImages[randomHead];
  torsoImage.src = torsoImages[randomTorso];
  legsImage.src = legsImages[randomLegs];
  headIndex = randomHead;
  torsoIndex = randomTorso;
  legsIndex = randomLegs;
  updateSelectorBox();
}


/** 
 * Updates the selector box text with the current head, torso and legs indices
*/
function updateSelectorBox()
{
	//Get the element we're going to change
	var selectorBox = document.getElementById("selector-box");
	
	//Set it's value to nothing, reset it.
	selectorBox.value = "";
	
	//Finally, just append each index to the string
	selectorBox.value += ("head: " + headIndex  + " | ");
	selectorBox.value += ("torso: " + torsoIndex + " | ");
	selectorBox.value += ("legs: " + legsIndex);
}


/**
 * Called when the head of the person is changed.
*/
function onHeadChange(offset)
{
	//Find the index which is offset from the current head index by the given offset.
	var offsetIndex = (headIndex + offset);
	
	//If it's negative, set the index to the last image:
	if(offsetIndex < 0)
		headIndex = headImages.length + offset;
	
	//Otherwise just add the offset and modulo by the length to "wrap around" the values
	else
		headIndex = (headIndex + offset) % headImages.length;
	
	//Fire callback for when the body has changed
	onBodyChanged();
}


/**
 * Called when the torso of the person is changed.
*/
function onTorsoChange(offset)
{
	//Find the index which is offset from the current torso index by the given offset.
	var offsetIndex = (torsoIndex + offset);
	
	//If it's negative, set the index to the last image:
	if(offsetIndex < 0)
		torsoIndex = torsoImages.length + offset;
	
	//Otherwise just add the offset and modulo by the length to "wrap around" the values
	else
		torsoIndex = (torsoIndex + offset) % torsoImages.length;
	
	//Fire callback for when the body has changed
	onBodyChanged();
}


/**
 * Called when the legs of the person is changed.
*/
function onLegsChange(offset)
{
	//Find the index which is offset from the current legs index by the given offset.
	var offsetIndex = (legsIndex + offset);
	
	//If it's negative, set the index to the last image:
	if(offsetIndex < 0)
		legsIndex = legsImages.length + offset;
	
	//Otherwise just add the offset and modulo by the length to "wrap around" the values
	else
		legsIndex = (legsIndex + offset) % legsImages.length;
	
	//Fire callback for when the body has changed
	onBodyChanged();
}


/**
 * Called when the user has changed the body in some way by choosing a different head, torso, and legs.
*/
function onBodyChanged()
{
	//Update the display showing which indices these are.
	updateSelectorBox();
	
	//Set head, torso and legs images
	headImage.src = headImages[headIndex];
	torsoImage.src = torsoImages[torsoIndex];
	legsImage.src = legsImages[legsIndex];
}


/**
 * Saves the current selection of head, torso and legs to local storage for retrieval later.
*/
function saveSelection()
{
	localStorage.setItem("chosenHead" , headIndex);
	localStorage.setItem("chosenTorso", torsoIndex);
	localStorage.setItem("chosenLegs" , legsIndex);
  changeTracker++
  document.getElementById("changeCount").innerHTML = changeTracker;
  localStorage.setItem("changeTracker", changeTracker);
}


/**
 * Loads the selection stored in local storage onto the page
*/
function loadSelection()
{
	headIndex = localStorage.getItem("chosenHead");
  torsoIndex = localStorage.getItem("chosenTorso");
  legsIndex = localStorage.getItem("chosenLegs");

	onBodyChanged();
}


function onKeyPressEvent(event) {
    var x = event.key;
    if(x == "z"){
      onHeadChange(+1);
    } else if(x == "x"){
      onHeadChange(-1);
    }
}

function resetCounter(){
  changeTracker = 0;
  localStorage.setItem("changeTracker", changeTracker);
  document.getElementById("changeCount").innerHTML = 0;
}