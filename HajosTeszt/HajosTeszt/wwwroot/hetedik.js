function letöltés() {
    fetch("questions.json")
        .then(response => response.json())
        .then(data => letöltésBefejeződött(data)
        );
}

function letöltésBefejeződött(d) {
    console.log("Sikeres letöltés")
    console.log(d)
    kérdések = d;
}

window.onload = () => {
    letöltés();
    kérdésMegjelenítés(0);

    document.getElementById("vissza").onclick = () => {

    }

    document.getElementById("előre").onclick = () => {

    }

    document.getElementById("válasz1").onclick = () => {
        if (kérdések[kérdés].correctAnswer == 1) {
            this.style.backgorund = "darkgreen";
        }
        else {
            this.style.background = "lightcoral";
        }
    }

    document.getElementById("válasz2").onclick = () => {
        if (kérdések[kérdés].correctAnswer == 2) {
            this.style.backgorund = "darkgreen";
        }
        else {
            this.style.background = "lightcoral";
        }
    }

    document.getElementById("válasz3").onclick = () => {
        if (kérdések[kérdés].correctAnswer == 3) {
            this.style.backgorund = "darkgreen";
        }
        else {
            this.style.background = "lightcoral";
        }
    }
}

function kérdésMegjelenítés(kérdés) {
    document.getElementById("kérdés_szöveg").innerHTML = 'kérdés';
    let kérdés_szöveg = document.getElementById("kérdés_szöveg");
    let válasz1 = document.getElementById("válasz1");
    let válasz2 = document.getElementById("válasz2");
    let válasz3 = document.getElementById("válasz3");

    kérdés_szöveg.innerHTML = kérdések[kérdés].questionText;
    kép.scr = "https://szoft1.comeback.hu/hajo/" + kérdések[kérdés].image;
    válasz1.innerText = kérdések[kérdés].answer1;
    válasz2.innerText = kérdések[kérdés].answer2;
    válasz3.innerText = kérdések[kérdés].answer3;
}