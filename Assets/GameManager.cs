using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Board GameBoard;
    private bool WinnerFound;
    public Player PlayingPlayer;
    public int playerTurn;

    // Start is called before the first frame update
    void Start()
    {
        // Saves which players turn it is.
        PlayingPlayer = GameBoard.PlayerList[1];
        WinnerFound = false;
        // Saves turn order
        playerTurn = 0;
        NextTurn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextTurn()
    {

        if (PlayingPlayer.AllPiecesHome() == true)
        {
            PlayingPlayer.RollThreeTimes();
        }
        else
        {
            Die.inst.DieRoll();
        }

        // If player har mindst 1 brik i marken slår playeren 1 gang og rykker
        // Spiller slår terning
        // Vælger brik. if dieroll == 6 må han flytte brik fra hjem til bordet.
        // if alle brikker er i mål er spillet slut 
        // else, næste spiller for sin tur, og starter fra allpieceshome();

    }

}
