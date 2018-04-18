using System.Collections.Generic;
using System.IO;
using System;

namespace PlacesBeen.Models
{
  public class Place
  {
    private string _cityName;
    private int _id;
    private string _landmark;
    private string _imageUrl;
    private static List<Place> _places = new List<Place> {};

    public Place (string cityName, string landmark, string imageUrl)
    {
      _cityName = cityName;
      _places.Add(this);
      _id = _places.Count;
      _landmark = landmark;
      _imageUrl =imageUrl;

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
    public string GetLandmark()
    {
      return _landmark;
    }
    public void SetLandmark(string newLandmark)
    {
      _landmark = newLandmark;
    }

    public string GetImageUrl()
    {
      return _imageUrl;
    }
    public void SetImageUrl(string newImageUrl)
    {
      _imageUrl = newImageUrl;
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
