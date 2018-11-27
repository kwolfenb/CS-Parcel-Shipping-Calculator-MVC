using System.Collections.Generic;

namespace Parcel.Models
{
  public class ParcelInput
  {
    private int _length;
    private int _height;
    private int _width;
    private int _weight;
    private static List<ParcelInput> _instances = new List<ParcelInput> {};


    public ParcelInput (int length, int height, int width, int weight)
    {
      _length = length;
      _width = width;
      _height = height;
      _weight = weight;
      _instances.Add(this);
    }

    public int GetVolume()
    {
      return _length*_width*_height;
    }

    public int GetCostToShip()
    {
      return (_length*_width*_height*_weight)/100;
    }

    // public static int GetTotal(){
    //   int cost = 0;
    //   foreach( ParcelInput parcel in _instances){
    //     cost += parcel.GetCostToShip();
    //   }
    //   return _totalCost;
    // }

    public static List<ParcelInput> GetAll()
    {
      return _instances;
    }

  }
}