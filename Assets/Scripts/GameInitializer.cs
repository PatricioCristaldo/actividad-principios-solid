using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    public enum InputMode { Keyboard, AI }
    public InputMode selectedInput = InputMode.Keyboard;

    [Tooltip("Arrastra aquí el GameObject Player que tenga PlayerMovement")]
    public PlayerMovement player;

    void Start()
    {
        if (player == null)
        {
            Debug.LogError("GameInitializer: asigna el Player en el inspector.");
            return;
        }

IInputService inputService = CreateInputService(selectedInput);

        player.Initialize(inputService);
        Debug.Log("Usando input de tipo: " + inputService.GetType().Name);
    }

    private IInputService CreateInputService(InputMode mode)
    {
        switch (mode)
        {
            case InputMode.Keyboard:
                return new KeyboardInput();
            case InputMode.AI:
                return new AIInput();
            default:
                return new KeyboardInput();
        }
    }
}
