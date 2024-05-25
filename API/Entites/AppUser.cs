using System;
using System.Text.Json.Serialization;

namespace API.Entites;

public class AppUser
{
    //these properties repersent column in database
    [JsonPropertyName("id")]
    public int Id { get; set; } // if the prop is Id then entity uses it as primary key or we can we annotations [key]
    [JsonPropertyName("username")]
    public string UserName { get; set;}
}
