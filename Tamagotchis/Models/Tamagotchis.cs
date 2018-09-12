using System.Collections;
using System.Collections.Generic;

namespace DigitalPet.Models
{
  public class Tamagotchis
  {
    private string _name;
    // private int  _food;
    // private int  _play;
    // private int _sleep;
    private static List<Tamagotchis> _instances= new List<Tamagotchis> {};
    public Tamagotchis(string name) /*, int food, int play, int sleep*/
    {
      _name = name;
      // _food = food;
      // _play = play;
      // _sleep = sleep;
    }
    // public int GetFood(int food)
    // {
    //   return _food;
    // }
    // public void SetFood()
    // {
    //   _food = food;
    // }
    // public int GetPlay(int play)
    // {
    //    return _play;
    // }
    // public void SetPlay()
    // {
    //   _play = play;
    // }
    // public int GetSleep(int sleep)
    // {
    //    return _sleep;
    // }
    // public void SetSleep()
    // {
    //   _sleep = sleep;
    // }
    public void SetName(string name)
    {
      _name = name;
    }
    public string GetName()
    {
      return _name;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static List<Tamagotchis> GetAll()
    {
      return _instances;
    }
  }
}
