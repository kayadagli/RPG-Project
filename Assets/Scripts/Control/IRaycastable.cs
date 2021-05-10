namespace RPG.Control
{
    public interface IRaycastable
    {
        CursorType GetCursorType();
        bool HandeRaycast(PlayerController callingController);
    }
}