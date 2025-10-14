using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : IInputService
{
    public Vector2 GetMovementInput()
    {
        // Usa los ejes definidos en Edit > Project Settings > Input Manager ("Horizontal" y "Vertical")
        return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}
