using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public char playerTyle = 'A';
    
    public int[] playerBlock = new int[3] { 1, 1, 1 };
    //플레이어가 서있는 블록의 위치 좌측부터 A,B,C 순
    private int[] blockBlock = new int[3] { 1, 1, 1 };
    //블록에 할당된 위치좌표 좌측부터 A,B,C 순
    private bool canMove = false;

    void main()
    {
       
        canMoveCheck();


        
        if (canMove == true)
        {
           

        }


    }

    
    void canMoveCheck()
    //플레이어의 이동 가능 여부 확인 함수
    {
        if (playerTyle == 'A')
        {
            if (playerBlock[0] == blockBlock[0] + 1)
            {
                if (playerBlock[1] == blockBlock[1])
                {
                    canMove = true;
                }
                if (playerBlock[2] == blockBlock[2])
                {
                    canMove = true;
                }
            }
            else if (playerBlock[0] == blockBlock[0] - 1)
            {
                if (playerBlock[1] == blockBlock[1])
                {
                    canMove = true;
                }
                if (playerBlock[2] == blockBlock[2])
                {
                    canMove = true;
                }

            }
            else
            {
                canMove = false;
            }
        }

        if (playerTyle == 'B')
        {
            if (playerBlock[1] == blockBlock[1] + 1)
            {
                if (playerBlock[0] == blockBlock[0])
                {
                    canMove = true;
                }
                if (playerBlock[2] == blockBlock[2])
                {
                    canMove = true;
                }
            }
            else if (playerBlock[1] == blockBlock[1] - 1)
            {
                if (playerBlock[0] == blockBlock[0])
                {
                    canMove = true;
                }
                if (playerBlock[2] == blockBlock[2])
                {
                    canMove = true;
                }

            }
            else
            {
                canMove = false;
            }
        }

        if (playerTyle == 'C')
        {
            if (playerBlock[2] == blockBlock[2] + 1)
            {
                if (playerBlock[1] == blockBlock[1])
                {
                    canMove = true;
                }
                if (playerBlock[0] == blockBlock[0])
                {
                    canMove = true;
                }
            }
            else if (playerBlock[2] == blockBlock[2] - 1)
            {
                if (playerBlock[1] == blockBlock[1])
                {
                    canMove = true;
                }
                if (playerBlock[0] == blockBlock[0])
                {
                    canMove = true;
                }

            }
            else
            {
                canMove = false;
            }
        }
    }
}
