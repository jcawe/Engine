namespace Engine.Managers
{
    public class ActorManager : IActorManager
    {
        public void Update(params IActor[] actors)
        {
            foreach(var actor in actors) actor.Update();
        }
    }
}