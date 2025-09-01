using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieces : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    public enum SpriteChoice
    {
        Pawn,
        Bishop,
        Rook,
        Knight,
        Queen,
        King,
    }

    public SpriteChoice spriteChoice;

    // Chess piece sprites
    public Sprite PawnSprite;
    public Sprite BishopSprite;
    public Sprite RookSprite;
    public Sprite KnightSprite;
    public Sprite QueenSprite;
    public Sprite KingSprite;


    void OnValidate()
    {
        if (spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();

        switch (spriteChoice)
        {
            case SpriteChoice.Pawn:
                spriteRenderer.sprite = PawnSprite;
                break;
            case SpriteChoice.Bishop:
                spriteRenderer.sprite = BishopSprite;
                break;
            case SpriteChoice.Rook:
                spriteRenderer.sprite = RookSprite;
                break;
            case SpriteChoice.Knight:
                spriteRenderer.sprite = KnightSprite;
                break;
            case SpriteChoice.Queen:
                spriteRenderer.sprite = QueenSprite;
                break;
            case SpriteChoice.King:
                spriteRenderer.sprite = KingSprite;
                break;
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;

        Vector2 CurrentPosition = transform.position;

        // Diagonal Gizmo vectors
        Vector2 DiagonalDirection = Vector2.up + Vector2.right;
        Vector2 DiagonalDirectionLeft = Vector2.up + Vector2.left;
        Vector2 Diagonal = CurrentPosition + (DiagonalDirection * 7f);
        Vector2 DiagonalDown = CurrentPosition + (-DiagonalDirection * 7f);
        Vector2 DiagonalLeft = CurrentPosition + (DiagonalDirectionLeft * 7f);
        Vector2 DiagonalRight = CurrentPosition + (-DiagonalDirectionLeft * 7f);

        // Straight vectors
        Vector2 Right = CurrentPosition + (Vector2.right * 7f);
        Vector2 Up = CurrentPosition + (Vector2.up * 7f);
        Vector2 Down = CurrentPosition + (Vector2.down * 7f);
        Vector2 Left = CurrentPosition + (Vector2.left * 7f);

        // King vectors
        Vector2 SmallUp = CurrentPosition + (Vector2.up * 1f);
        Vector2 KingDown = CurrentPosition + (Vector2.down * 1f);
        Vector2 KingRight = CurrentPosition + (Vector2.right * 1f);
        Vector2 KingLeft = CurrentPosition + (Vector2.left * 1f);
        Vector2 KingDiagonal = CurrentPosition + (DiagonalDirection * 1f);
        Vector2 KingDiagonalDown = CurrentPosition + (-DiagonalDirection * 1f);
        Vector2 KingDiagonalLeft = CurrentPosition + (DiagonalDirectionLeft * 1f);
        Vector2 KingDiagonalRight = CurrentPosition + (-DiagonalDirectionLeft * 1f);

        // Pawn vector
        Vector2 BigUp = CurrentPosition + (Vector2.up * 2f);
        Vector2 BigDown = CurrentPosition + (Vector2.down * 2f);
        Vector2 SmallDown = CurrentPosition + (Vector2.down * 1f);

        // Knight points
        Vector2 Knight1 = BigUp + (Vector2.right * 1f);  // top right
        Vector2 Knight2 = SmallUp + (Vector2.right * 2f); // 2nd right
        Vector2 Knight3 = SmallDown + (Vector2.right * 2f); // 3rd right
        Vector2 Knight4 = BigDown + (Vector2.right * 1f); // bottom right
        Vector2 Knight5 = BigDown + (Vector2.left * 1f); // bottom left
        Vector2 Knight6 = SmallDown + (Vector2.left * 2f); // 3rd left
        Vector2 Knight7 = SmallUp + (Vector2.left * 2f); // 2nd left
        Vector2 Knight8 = BigUp + (Vector2.left * 1f); // top left




        if (spriteRenderer.sprite == BishopSprite || spriteRenderer.sprite == QueenSprite)
        {
            Gizmos.DrawLine(CurrentPosition, Diagonal);
            Gizmos.DrawLine(CurrentPosition, DiagonalDown);
            Gizmos.DrawLine(CurrentPosition, DiagonalLeft);
            Gizmos.DrawLine(CurrentPosition, DiagonalRight);
        }

        if(spriteRenderer.sprite == RookSprite || spriteRenderer.sprite == QueenSprite)
        {
            Gizmos.DrawLine(CurrentPosition, Right);
            Gizmos.DrawLine(CurrentPosition, Up);
            Gizmos.DrawLine(CurrentPosition, Left);
            Gizmos.DrawLine(CurrentPosition, Down);
        }

        if(spriteRenderer.sprite == KingSprite)
        {
            Gizmos.DrawLine(CurrentPosition, KingRight);
            Gizmos.DrawLine(CurrentPosition, SmallUp);
            Gizmos.DrawLine(CurrentPosition, KingLeft);
            Gizmos.DrawLine(CurrentPosition, KingDown);
            Gizmos.DrawLine(CurrentPosition, KingDiagonal);
            Gizmos.DrawLine(CurrentPosition, KingDiagonalDown);
            Gizmos.DrawLine(CurrentPosition, KingDiagonalLeft);
            Gizmos.DrawLine(CurrentPosition, KingDiagonalRight);
        }

        if(spriteRenderer.sprite == PawnSprite)
        {
            Gizmos.DrawLine(CurrentPosition, BigUp);
        }

        if(spriteRenderer.sprite == KnightSprite)
        {
            Gizmos.DrawLine(CurrentPosition, BigDown);
            Gizmos.DrawLine(BigUp, Knight1);
            Gizmos.DrawLine(SmallUp, Knight2);
            Gizmos.DrawLine(SmallDown, Knight3);
            Gizmos.DrawLine(BigDown, Knight4);
            Gizmos.DrawLine(BigDown, Knight5);
            Gizmos.DrawLine(SmallDown, Knight6);
            Gizmos.DrawLine(SmallUp, Knight7);
            Gizmos.DrawLine(BigUp, Knight8);

        }

    }

}
