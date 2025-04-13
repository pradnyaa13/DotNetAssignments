const winningPatterns = [
    [0, 1, 2], [3, 4, 5], [6, 7, 8],
    [0, 3, 6], [1, 4, 7], [2, 5, 8],
    [0, 4, 8], [2, 4, 6],
];

class TicTacToeLogic {
    constructor(player1, player2) {
        this.arrayOfGridPositions = Array.from({ length: 9 }, (_, i) => (i + 1).toString());
        this.player1UserName = player1;
        this.player2UserName = player2;
        this.currentPlayer = 1;
        this.countThePositionsOccupied = 0;
        this.gameInProgress = true;
        this.totalGridTiles = 9;
    }

    StartTheGame() {
        const gridContainer = document.getElementById("gameGrid");
        gridContainer.style.display = "grid";
        gridContainer.innerHTML = "";

        for (let i = 0; i < 9; i++) {
            const cell = document.createElement("div");
            cell.className = "cell";
            cell.innerText = this.arrayOfGridPositions[i];
            cell.dataset.index = i;
            cell.classList.add('cellColor');
            cell.addEventListener("click", () => this.makeMove(i, cell));
            gridContainer.appendChild(cell);
            
        }
    }

    makeMove(index, cell) {
        if (!this.gameInProgress || cell.innerText === "X" || cell.innerText === "O") return;

        const symbol = (this.currentPlayer === 1) ? "X" : "O";
        this.arrayOfGridPositions[index] = symbol;
        cell.innerText = symbol;
        this.countThePositionsOccupied++;

        if (this.WinnerChecking(this.arrayOfGridPositions, symbol)) {
            alert(`Player-${this.currentPlayer} (${this.currentPlayer === 1 ? this.player1UserName : this.player2UserName}) Won!`);
            this.gameInProgress = false;
        } else if (this.countThePositionsOccupied === this.totalGridTiles) {
            alert("It's a Draw! No player won! Better Luck Next Time!");
            this.gameInProgress = false;
        } else {
            this.currentPlayer = this.currentPlayer === 1 ? 2 : 1;
        }
    }

    WinnerChecking(gameBoard, playerSymbol) {
        for (let pattern of winningPatterns) {
            if (gameBoard[pattern[0]] === playerSymbol &&
                gameBoard[pattern[1]] === playerSymbol &&
                gameBoard[pattern[2]] === playerSymbol) {
                return true;
            }
        }
        return false;
    }
}