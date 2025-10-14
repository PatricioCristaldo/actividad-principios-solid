using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private IInputService inputService;

    public void Initialize(IInputService service)
    {
        inputService = service;
    }

    void Update()
{
    if (inputService == null) return;

    // 1️⃣ Movimiento
    Vector2 input = inputService.GetMovementInput();
    Vector3 movement = new Vector3(input.x, input.y, 0f) * speed * Time.deltaTime;
    transform.Translate(movement, Space.World);

    // 2️⃣ Limitar posición al área visible de la cámara
    ClampToScreenBounds();
}

void ClampToScreenBounds()
{
    // Obtenemos la cámara principal
    Camera cam = Camera.main;

    // Convertimos la posición del jugador a coordenadas de viewport (0–1)
    Vector3 viewPos = cam.WorldToViewportPoint(transform.position);

    // Limitamos en ambos ejes (0 = borde izquierdo/abajo, 1 = borde derecho/arriba)
    viewPos.x = Mathf.Clamp01(viewPos.x);
    viewPos.y = Mathf.Clamp01(viewPos.y);

    // Convertimos de nuevo a coordenadas del mundo
    transform.position = cam.ViewportToWorldPoint(viewPos);
}

}
