package Strategies.GameWinningStrategies;

import Model.Board;
import Model.Cell;
import Model.Player;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class OrderOneGameWinningStrategy implements IGameWinningStrategy {

    /*
        Algo of O(1):
        For each row, maintain the count of how many times a character is present.
        For each column, maintain the count of how many times a character is present.
        For each diagonal, maintain the count of how many times a character is present.

        Maintain the count in HashMap<Character, Integer>

        If the count of any character is equal to the size of that row/col/diagonal,
        return true.
     */


    // For every row create a Hashmap so List of HM which will contain X:0  Y:0
    private List<HashMap<Character, Integer>> rowCharCounts;
    private List<HashMap<Character, Integer>> colCharCounts;

    // Initialize the HashMaps
    private void initializeCounts(Board board) {
        rowCharCounts = new ArrayList<>();
        colCharCounts = new ArrayList<>();

        for (int i = 0; i < board.getDimension(); ++i) {
            rowCharCounts.add(new HashMap<>());
            colCharCounts.add(new HashMap<>());
        }
    }

    @Override
    public boolean CheckIfWon(Board board, Player player, Cell moveCell) {
        if (rowCharCounts == null) {
            initializeCounts(board);
        }

        int row = moveCell.getRow();
        int col = moveCell.getColumn();

        // If that character is not yet present in the HM, add it with initially 0.
        if (!rowCharCounts.get(row).containsKey(moveCell.getSymbol().getCharacter())) {
            rowCharCounts.get(row).put(moveCell.getSymbol().getCharacter(), 0);
        }

        // If that character is not yet present in the HM, add it with initially 0.
        if (!colCharCounts.get(col).containsKey(moveCell.getSymbol().getCharacter())) {
            colCharCounts.get(col).put(moveCell.getSymbol().getCharacter(), 0);
        }

        // Increment the count by whatever is the current value + 1.
        rowCharCounts.get(row).put(
                moveCell.getSymbol().getCharacter(),
                1 + rowCharCounts.get(row).get(moveCell.getSymbol().getCharacter())
        );

        colCharCounts.get(col).put(
                moveCell.getSymbol().getCharacter(),
                1 + colCharCounts.get(col).get(moveCell.getSymbol().getCharacter())
        );

        // If row or col value == dimension than its win
        if (rowCharCounts.get(row).get(moveCell.getSymbol().getCharacter()).equals(board.getDimension())) {
            return true;
        }

        // If this value becomes equals to dimension
        if (colCharCounts.get(col).get(moveCell.getSymbol().getCharacter()).equals(board.getDimension())) {
            return true;
        }

        // Diagonal implementation is still left.
        // Left diagonal, i==j
        // Right diagonal or opposite diagonal, i+j == n-1
        return false;
    }
}
