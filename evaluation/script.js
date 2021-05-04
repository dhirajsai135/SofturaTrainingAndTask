function myfunction1() {
    var msg = document.getElementById("txt1Input").value;
    var msg1 = document.getElementById("txt2Input").value;
    txt2Input.classList.add("border");
    if (msg.length == msg1.length) {
        txt2Input.classList.remove("border-danger");
        txt2Input.classList.add("border-success");
        var bull = 0;
        var cow = 0;
        var check=0;
        for (i = 0; i < msg.length; i++) {
            if (msg[i] == msg1[i]) {
                cow += 1;
            }
            else {
                for (j = 0; j < msg.length; j++) {
                    if (msg[i] == msg1[j] && i != j) {
                        bull += 1;
                        check+=1;
                    }
                }
            }
        }
        document.getElementById("errorInput").innerHTML = cow + " COW " + bull + " BULL";
        if (cow == msg.length) {
            document.getElementById("resultFinal").innerHTML = "!!!!!!.....Person One Wins the Game....!!!!!! ";
        }
        else {
            if(bull==msg.length){
                document.getElementById("resultFinal").innerHTML = "!!!!!!.....Person Two Wins the Game....!!!!!! ";

            }

        }
        
    } else {
        inputText1.classList.add("border-danger");
        document.getElementById("errMsg1").innerHTML = "Must enter " + msg.length + " letter a Word"
        document.getElementById("resultFinal").innerHTML = "";
    }


}