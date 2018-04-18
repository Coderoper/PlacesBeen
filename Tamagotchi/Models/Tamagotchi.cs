using System.Collections.Generic;
using System.IO;
using System;

namespace Tamagotchi.Models
{
  public class Pet
  {
    private string _name;
    private int _sleep;
    private int _food;
    private int _attention;
    private int _rest;

    private static List<Pet> _pets = new List<Pet> {};

    public Pet (string name, int sleep, int food, int attention, int rest)
    {
      _name=name;
      _sleep = sleep;
      _food = food;
      _attention = attention;
      _rest=rest;
      _pets.Add(this);
      _id = _pets.Count;
    }
    public string GetName()
    {
      return _name
    }
    public void SetName()
    {
      _name = newName
    }
    public int GetFood()
    {
      return _food;
    }
    public void SetFood(int newFood)
    {
      _food = newFood;
    }
    public int GetSleep()
    {
      return _sleep;
    }
    public void SetSleep(int newSleep)
    {
      _sleep = newSleep
    }
    public int GetAttention()
    {
      return _attention;
    }
    public void SetAttention(int newSleep)
    {
      _attention = newAttention
    }
