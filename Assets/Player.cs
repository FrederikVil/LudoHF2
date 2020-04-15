using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public List<Pawn> Pawns = new List<Pawn>();
    public Board GameBoard;
    public Player PlayingPlayer { get; set; }
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool AllPiecesHome()
    {
        bool result = true;
        foreach (Pawn item in Pawns)
        {
            if (item.Position != -1)
            {
                result = false;
            }
        }

        return result;
    }

    public void RollThreeTimes()
    {
        int i = 0;
        bool Six = false;
        while (i != 2 || Six == true)
        {
            Die.inst.DieRoll();

            if (Die.inst.finalSide == 6)
            {
                Six = true;
            }
        }
    }

    public bool IsItMyTurn()
    {
        if (gm.PlayingPlayer == this)
        {
            return true;
        }
        else
        {
            return false;
        }


    }
}
