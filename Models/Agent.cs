namespace Agents
{
      public class Agent(int id, string codeName, string realName, string location, string status, int missionsCompleted)
      {
            int Id { get; set; } = id;
            string CodeName { get; set; } = codeName;
            string RealName { get; set; } = realName;
            string Location { get; set; } = location;
            string Status { get; set; } = status;
            int MissionsCompleted { get; set; } = missionsCompleted;

            public override string ToString()
            {
                  return $"Agent [ID: {Id}, Code: {CodeName}, Name: {RealName}, Location: {Location}, Status: {Status}, Missions: {MissionsCompleted}]";
            }
      }
}