# actividad-principios-solid

---

## 🧱 Principios SOLID aplicados

### 🟦 **S — Principio de Responsabilidad Única**

Cada clase del proyecto tiene **una única responsabilidad clara**:

| Clase | Responsabilidad |
|--------|------------------|
| `PlayerMovement` | Mover al jugador en base al input recibido. |
| `KeyboardInput` | Detectar el movimiento del usuario desde el teclado. |
| `AIInput` | Generar un movimiento automático simulado (sin intervención del jugador). |
| `GameInitializer` | Configurar la escena e inyectar la dependencia correspondiente al `PlayerMovement`. |

**Beneficio:**  
Al separar las responsabilidades, el código es más legible y cada clase se puede modificar o extender sin afectar las demás. Por ejemplo, agregar un nuevo tipo de input (como `GamepadInput`) no requiere tocar el código de movimiento.

---

### 🟩 **I — Principio de Inversión de Dependencias**

El script `PlayerMovement` **no depende directamente de una clase concreta** como `KeyboardInput`, sino de la **abstracción `IInputService`**.  

```csharp
public interface IInputService
{
    Vector2 GetMovementInput();
}
