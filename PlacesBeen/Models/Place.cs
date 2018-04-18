using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Place
  {
    private string _cityName;
    private int _id;
    private static List<Place> _places = new List<Place> {};

    public Place (string cityName)
    {
      _cityName = cityName;
      _places.Add(this);
      _id = _places.Count;
    }
    public string GetCityName()
    {
      return _cityName;
    }
    public void SetCityName(string newCityName)
    {
      _cityName = newCityName;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Place> GetAll()
    {
      return _places;
    }
    public static void ClearAll()
    {
      _places.Clear();
    }

    public static Place Find(int searchId)
    {
      return _places[searchId-1];
    }

  }
}
