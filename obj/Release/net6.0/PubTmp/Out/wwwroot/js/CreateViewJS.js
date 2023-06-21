
    function test() {
        document.getElementById("dat1").disabled = true;

        }
    function test2() {

        document.getElementById("dat2").disabled = true;

        }
    function verifyAnswer() {
        alert("This is an alert dialog box");
            //disable all the radio button
            document.getElementById("dat1").disabled = true;
            document.getElementById("dat2").disabled = true;
            document.getElementById("dat3").disabled = true;
            //get the value if checkbox is checked
            var dev = document.getElementById("myCheck").checked;

            if (dev == true) {
        //enable all the radio button
        document.getElementById("dat1").disabled = false;
                document.getElementById("dat2").disabled = false;
                document.getElementById("dat3").disabled = false;
            }
        }