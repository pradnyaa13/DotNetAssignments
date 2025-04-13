class PrintTheGrid {
    static Display(grid) {
        console.log("Grid:\n");
        console.log("--+--+--+");
        console.log(grid[0] + " | " + grid[1] + " | " + grid[2]);
        console.log("--+--+--+");
        console.log(grid[3] + " | " + grid[4] + " | " + grid[5]);
        console.log("--+--+--+");
        console.log(grid[6] + " | " + grid[7] + " | " + grid[8]);
        console.log("--+--+--+");
    }
}