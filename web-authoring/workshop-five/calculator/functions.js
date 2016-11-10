//The running total of the calculator, the current sum to add/subtract/divide/multiply.
var runningTotal = 0;

    //The current operator - which operation should be applied - add, subtract, multiply, divide.
    var currentOperator = "";
    
    //The current operand - the right hand number of the sum which should be added to the running total.
    var currentOperand  = 0;
    
    //And whether or not we have pressed these, so we can check later on.
    var hasPressedOperator = false;
    var hasPressedOperand  = false;
    var hasPressedEquals   = false;
    
    /**
     * This is called when the page first loads.
     */
     window.onload = function()
     {
      //Lets get all the number buttons on the page, by class. This gives us an array of 
      //buttons we need to add listeners to.
      var allButtons = document.getElementsByClassName("button");
      
      for(var i = 0; i < allButtons.length; i++)
      {
        //Iterate through each button, store it locally for the sake of brevity:
        var button = allButtons[i];
        
        //And add a listener.. in this case, we will be passing the mouse data so we know which button we have pressed.
        button.addEventListener("click", function(mouseData)
        {
          //And when we click the button, we will call "onNumberButtonClicked" with the text of this button, so we can use
          //it in the calculator's logic.
          onNumberButtonClicked(mouseData.target.innerText);
        });
      }

      var allOperators = document.getElementsByClassName("operator");
      
      for(var i = 0; i < allOperators.length; i++)
      {
        //Iterate through each button, store it locally for the sake of brevity:
        var operator = allOperators[i];
        
        //And add a listener.. in this case, we will be passing the mouse data so we know which button we have pressed.
        operator.addEventListener("click", function(mouseData)
        {
          //And when we click the button, we will call "onNumberButtonClicked" with the text of this button, so we can use
          //it in the calculator's logic.
          onOperatorButtonClicked(mouseData.target.innerText);

        });
      }


      
      //Finally, lets update the output box
      updateDisplay();
    }
    
    /**
     * Called when one of the number buttons is pressed in the calculator.
     */
     function onOperatorButtonClicked(value)
     {
      //Current value doesn't equal zero and we can do stuff with it
      if(!runningTotal == 0){

        switch(value){
          case "+":
            //Set operator to clicked button
            currentOperator = "+";
            //Set operator press to true
            hasPressedOperator = true;
            //Update the display to reflect the change
            updateDisplay();
            break;
          case "-":
            //Set operator to clicked button
            currentOperator = "-";
            //Set operator press to true
            hasPressedOperator = true;
            //Update the display to reflect the change
            updateDisplay();
            break;
          case "x":
            //Set operator to clicked button
            currentOperator = "*";
            //Set operator press to true
            hasPressedOperator = true;
            //Update the display to reflect the change
            updateDisplay();
            break;
          case "/":
            //Set operator to clicked button
            currentOperator = "/";
            //Set operator press to true
            hasPressedOperator = true;
            //Update the display to reflect the change
            updateDisplay();
            break;
          case "=":
              //Check for a number and operator 
              if(hasPressedOperand && hasPressedOperator){         
                //Set it so that we know they have just pressed the equals symbol
                hasPressedEquals = true;

                //Check currentOperator
                if(currentOperator == "+"){
                  runningTotal += parseInt(currentOperand);
                  //Reset the variables used
                  hasPressedOperand = false;
                  hasPressedOperator = false;
                  currentOperand = 0;
                  currentOperator = "";
                  updateDisplay();
                } else if (currentOperator == "-"){
                  runningTotal -= parseInt(currentOperand);
                  //Reset the variables used
                  hasPressedOperand = false;
                  hasPressedOperator = false;
                  currentOperand = 0;
                  currentOperator = "";
                  updateDisplay();
                } else if (currentOperator == "*"){
                  runningTotal *= parseInt(currentOperand);
                  //Reset the variables used
                  hasPressedOperand = false;
                  hasPressedOperator = false;
                  currentOperand = 0;
                  currentOperator = "";
                  updateDisplay();
                } else if (currentOperator == "/"){
                  runningTotal /= parseInt(currentOperand);
                  //Reset the variables used
                  hasPressedOperand = false;
                  hasPressedOperator = false;
                  currentOperand = 0;
                  currentOperator = "";
                  updateDisplay();
                  } else {
                  //  runningTotal /= parseInt(currentOperand);
                  }
                } else {

                }
        // -------
      }
    }
  }

      //Finally, update the display to show the new changes.
      updateDisplay();

    /**
     * Called when one of the number buttons is pressed in the calculator.
     */
     function onNumberButtonClicked(value)
     {
      if(!hasPressedOperator)
      {
        //They've pressed a button, and they haven't pressed an operator yet.. so this is the left number.
        //..
        
        //If they've just pressed the equals symbol, overwrite the number that is in the display.
        if(hasPressedEquals)
          runningTotal = parseInt(value);
        
        //Otherwise, append the number to the running total as a string, and convert back to an int.
        //e.g. int("1" + "2") = 12.
        else
          runningTotal = parseInt(runningTotal + value);
      }
      else
      {
        //They've pressed a button, and an operator hasn't been pressed yet.. so this is the right number.
        //..
        
        //If it's 0, overwrite the total with the value that was pressed.
        if(currentOperand == 0)
          currentOperand = value;
        
        //Otherwise, append the number and cast back to an int.
        else
          currentOperand = parseInt(currentOperand + value);

        //And this is the right hand number which has been pressed, so they have given an operand!
        hasPressedOperand = true;
      }
      
      hasPressedEquals = false;
      
      //Finally, update the display to show the new changes.
      updateDisplay();
    }

    
    /**
     * Updates the output display with the current running total, operands and operator.
     */
     function updateDisplay()
     {
      //We need to build a string to show. The first item is the current running total:
      var string = runningTotal;

      //Then we add the operator if they have pressed this
      if(hasPressedOperator)
        string += " " + currentOperator;
      
      //And finally we add the right operand, the value to add when equals is pressed.
      if(hasPressedOperand)
        string += " " + currentOperand;
      
      //We then simply set the value of the output field to the string we built
      document.getElementById("output").value = string;
    }
     
    
    /**
     * Called when the user presses the clear button.
     */
     function onClearClick()
     {
      //Reset all the variables back to their initial state.
      runningTotal = 0;
      currentOperand = 0;
      currentOperator = "";
      hasPressedOperand = false;
      hasPressedOperator = false;
      
      //Update the display to show the changes.
      updateDisplay();
    }
