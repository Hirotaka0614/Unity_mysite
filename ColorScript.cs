using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    public int  X;
    public int  Y;
    public static int[,] list = new int[7, 7];
    public static bool firsttouch = false;
    public static int touchcolor;
    
    /*
    float[,] blockcolor =
    {
        {248f/255f,96f/255f,67f/255f},
        {94f/255f,140f/255f,246f/255f},
        {71f/255f,248f/255f,173f/255f},
        {205f/255f,114f/255f,243f/255f},
        {248f/255f,185f/255f,62f/255f},
        {255,205,0}
    };
    */
    float[,] blockcolor =
    {
        {248f/255f,102f/255f,102f/255f},
        {212f/255f,153f/255f,255f/255f},
        {101f/255f,251f/255f,101f/255f},
        {28f/255f,221f/255f,224f/255f},
        {248f/255f,185f/255f,62f/255f},
        {124f/255f,133f/255f,246f/255f}
    };
    
    
    
   
    void Start()
    {
        
    }

    void Update()
    {
      
        this.GetComponent<Renderer>().material.color = new Color(blockcolor[list[X, Y], 0], blockcolor[list[X, Y], 1], blockcolor[list[X, Y], 2]);
        
    }
}
