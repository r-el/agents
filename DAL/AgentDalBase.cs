namespace Agents
{
      public abstract class AgentDalBase
      {
            public abstract void AddAgent(Agent agent);
            public abstract List<Agent> GetAllAgents();
            public abstract void UpdateAgentLocation(int agentId, string newLocation);
            public abstract void DeleteAgent(int agentId);
      }
}