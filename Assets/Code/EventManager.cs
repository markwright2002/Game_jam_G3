public static class EventManager
{
    public delegate void ScoreAction(int value);
    public static event ScoreAction OnScore;

    public delegate void GameAction();
    public static event GameAction OnHit;
    public static event GameAction OnMiss;

    public delegate void MinigameEndAction();
    public static event MinigameEndAction OnMinigameEnd;

    public static void InvokeOnScore(int value)
    {
        OnScore?.Invoke(value);
    }

    public static void InvokeOnMinigameEnd()
    {
        OnMinigameEnd?.Invoke();
    }

    public static void InvokeOnHit()
    {
        OnHit?.Invoke();
    }

    public static void InvokeOnMiss()
    {
        OnMiss?.Invoke();
    }

}
