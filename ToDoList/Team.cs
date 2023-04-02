namespace ToDoList{
    
    public class Team{
    private Dictionary<int, string> teamMembers;

    public Dictionary<int, string> TeamMembers { get => teamMembers; set => teamMembers = value; }

    public Team() {
        teamMembers = new Dictionary<int, string>();
    }

}
    

}
