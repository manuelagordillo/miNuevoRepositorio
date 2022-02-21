using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject piece; // �eza que se clone tantas veces como se le indique
    public int width, heigth; // altura y anchura del tablero de juego


    private void Start()
    {
        for( int i=0; i < width; i++)
        {
            for (int j = 0; j < heigth; j++)
            {
                Instantiate(piece, new Vector2(i, j), Quaternion.identity); 
            }
        }
    }
}
