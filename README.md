A simple **MathProject** which performs basic calculations:
* addition,
* subtraction,
* multiplication,
* division,

with addition of mini-games that make practicing math problems more exciting.

**Additional features:**
* history of games
* record of time spend on a given minigame
* separate difficulties for different modes (WIP)
  - difficulties should be moved to the GameEngine class rather than Helpers.
 
Glitches to fix:
* showing 0 in game's history when user input is not equal to a given difficulty
* if user chooses non-existent difficulty, all the numbers in game become "0"
* when choosing option "V" for game's history, the user is prompted with choosing difficulty, THEN goes to game's history
