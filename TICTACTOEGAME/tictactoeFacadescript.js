class TicTacToeFacadePattern {
    constructor(player1, player2) {
        this.tictacLogic = new TicTacToeLogic(player1, player2);
    }

    FacadeDesignPatternForTicTacToe() {
        this.tictacLogic.StartTheGame();
    }
}