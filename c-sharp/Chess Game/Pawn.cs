using System;


public class Pawn : ChessPiece{
    private bool hasMoved;
    
    public Pawn(bool isWhite):base("Pawn", isWhite){
        this.hasMoved=false;
    }
    
    public void Move(bool isTwoMoves){
        if(isTwoMoves && !hasMoved){
            string color = this.GetIsWhite()? "White":"Black";
            Console.WriteLine($"{color} pawn has moved two steps");
            hasMoved=true;
        } else if (!isTwoMoves) {
            string color = this.GetIsWhite()? "White":"Black";
            Console.WriteLine($"{color} pawn has moved one step");
            hasMoved=true;
        }
    }
    
    public override string ToString(){
         string color = this.GetIsWhite()? "White":"Black";
           string movedStatus = hasMoved ? "already moved" : "not yet moved";
         return $"{color} pawn has {movedStatus}";
    }
    
}
