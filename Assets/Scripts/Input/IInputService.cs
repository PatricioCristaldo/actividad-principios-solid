using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputService
{
    /// <summary>
    /// Devuelve un Vector2 con el input de movimiento (x = horizontal, y = vertical).
    /// </summary>
    Vector2 GetMovementInput();
}
