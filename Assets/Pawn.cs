using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    public int Position;
    public Board GameBoard;
    
  
    // Start is called before the first frame update
    void Start()
    {
        Position = -1;
    }

    // Update is called once per frames
    void Update()
    {
        transform.position = GameBoard.Fields[Position].transform.position;
    }

    private void OnMouseDown()
    {
        Position += Die.inst.finalSide;
    }
}
