document.getElementById('btnRollDice').addEventListener('click', function () {
    fetch('/home/rolldice')
        .then(res => res.json())
        .then(gameMatrix => {

            [...document.querySelectorAll('.td-seq')].map(x => x.classList.remove('bg-success'));

            if (gameMatrix.isWon) {
                document.getElementById('divWin').removeAttribute("hidden");
                document.getElementById('btnNewGame').removeAttribute("hidden");
                document.getElementById('btnRollDice').setAttribute("hidden", true);
                return;
            }

            document.getElementById('lblDiceValue').innerText = gameMatrix.diceValue;
            var element = document.getElementById(gameMatrix.position);
            element.classList.add('bg-success');
        })
});

document.getElementById('btnNewGame').addEventListener('click', function () {
    fetch('/home/ResetGame')
        .then(res => {
            document.getElementById('btnRollDice').removeAttribute("hidden");
            document.getElementById('btnNewGame').setAttribute("hidden", true);
            document.getElementById('divWin').setAttribute("hidden", true);
            document.getElementById('lblDiceValue').innerText = 0;
        })
});

