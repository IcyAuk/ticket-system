using Microsoft.AspNetCore.SignalR;

namespace TicketSystem.Models;

public class Ticket
{
    public int Id {get;set;}
    public string Title {get;set;} = string.Empty;
    public string Description {get;set;} = string.Empty;
    public string Status {get;set;} = "Open";
    public string Priority {get;set;} = "Medium";
    public DateTime CreatedAt {get;set;} = DateTime.UtcNow;

    //foreign key
    public int CreatedById {get;set;}
    public User CreatedBy {get;set;} = null;

    public int? AssignedToId {get;set;}
    public User? AssignedTo {get;set;}

}