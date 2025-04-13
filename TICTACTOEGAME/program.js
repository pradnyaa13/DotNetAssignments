console.log(" Tic Tac Toe Game");

function startGame() {
    const player1 = document.getElementById("player1").value;
    const player2 = document.getElementById("player2").value;

    if (!player1 || !player2) {
        alert("Please enter both player names!");
        return;
    }

    const tictacFacadeObject = new TicTacToeFacadePattern(player1, player2);
    tictacFacadeObject.FacadeDesignPatternForTicTacToe();
}