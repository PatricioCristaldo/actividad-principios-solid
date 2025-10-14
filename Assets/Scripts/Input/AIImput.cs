using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIInput : IInputService
{
    private float timer = 0f;

    public Vector2 GetMovementInput()
    {
        // Ejemplo sencillo: alterna mover a la derecha y quedarse quieto cada 2 segundos.
        timer += Time.deltaTime;
        if (timer < 2f) return Vector2.right;
        if (timer < 4f) return Vector2.zero;
        if (timer >= 4f) timer = 0f;
        return Vector2.right;
    }
}
