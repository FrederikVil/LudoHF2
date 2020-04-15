using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pawn : MonoBehaviour
{
    public int Position { get; set; }
    public Board GameBoard;
    public Player Owner;
    public Text text;
  
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.FindGameObjectWithTag("UIText").GetComponent<Text>();
        Position = -1;
    }

    // Update is called once per frames
    void Update()
    {
        if (Position > 0)
        {
            transform.position = GameBoard.Fields[Position].transform.position;
        }
    }

    public void GoHome()
    {

    }

    private void OnMouseDown()
    {
        if (Owner.PlayingPlayer == Owner.IsItMyTurn()) 
        {
            Position += Die.inst.finalSide;
        }
        else
        {
            try
            {
                text.text = "It is not your turn";
            }
            catch (Exception)
            {
                Debug.Log(gameObject.name);
            }
            
        }
    }
}
