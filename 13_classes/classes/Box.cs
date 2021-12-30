using System;

namespace classes
{ 
    public class Box {
      // this is also a data type
      public double Length {get; set;}
      public double Width { get; set; }
      public double Height { get; set; }

      public double getVolume() {
        return Length * Width * Height;
      }
    }

}