using System;


public class ChessPiece {
    private string pieceType;
    private bool isWhite;
    
    
    public ChessPiece(string pieceType, bool isWhite){
        this.pieceType=pieceType;
        this.isWhite = isWhite;
    }
    
    public string GetPieceType(){
        return pieceType;
    }
    
    public bool GetIsWhite(){
        return isWhite;
    }
}
