namespace Engine.Managers
{
    public interface IActorManager
    {
         void Update(params IActor[] actors);
    }
}