document.getElementById('btnRollDice').addEventListener('click', function () {
    fetch('/home/rolldice')
        .then(res => res.text())
        .then(diceValue => {

            let previousPosition = document.getElementById('previousPosition').value;
            document.getElementById('lblDiceValue').innerText = diceValue;

            let newPosition = Number(previousPosition) + Number(diceValue);
            document.getElementById('previousPosition').value = newPosition

            if (previousPosition != 0) {
                var elementPre = document.getElementById(previousPosition);
                elementPre.classList.remove('bg-success');
            }

            if (previousPosition >= 100 || newPosition >= 100) {
                document.getElementById('previousPosition').value = 0
                document.getElementById('divWin').removeAttribute("hidden");
                document.getElementById('btnNewGame').removeAttribute("hidden");
                document.getElementById('btnRollDice').setAttribute("hidden",true);
            }
            else {
                var element = document.getElementById(newPosition);
                element.classList.add('bg-success');
            }
        })

});

document.getElementById('btnNewGame').addEventListener('click', function () {
    document.getElementById('btnRollDice').removeAttribute("hidden");
    document.getElementById('btnNewGame').setAttribute("hidden", true);
    document.getElementById('divWin').setAttribute("hidden", true);
    document.getElementById('lblDiceValue').innerText = 0;
});