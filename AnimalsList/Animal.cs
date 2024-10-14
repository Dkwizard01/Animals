using System;

public class Animal
{
    #region  Properties_Fields
    public string Name { get; set; }
    public string Kind { get; set; }
    public int Legs { get; set; }
    
    public int ID { get; set; }
    public string Description;
    public int sleepingHours { get; set; }


    #endregion
    #region Constructor
    public Animal(string name, string kind, int id, int legs, string description)
    {
        this.Name = name;
        this.Kind = kind;
        this.ID = id;
        this.Legs = legs;

        this.Description = description;


    }
    #endregion
    #region methods
    public void Sleep(int numOfSleepingHours)
    {
            sleepingHours += numOfSleepingHours;

    }
    #endregion
}