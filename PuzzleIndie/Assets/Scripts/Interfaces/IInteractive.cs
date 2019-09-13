

/// <summary>
/// Interface for elenemts the player can interact with by pressing the interact button.
/// </summary>
public interface IInteractive
{
    string DisplayText { get; }
    void InteractWith();
}
