using System;

namespace API.Entites;

public class AppUser
{
    //these properties repersent column in database
    public int Id { get; set; } // if the prop is Id then entity uses it as primary key or we can we annotations [key]
    public string UserName { get; set;}
}
