using System;

namespace classes
{ 
    public class Person {
      // this is also a data type
      public string FirstName {get; set;}
      public string LastName { get; set; }
      private int _age;

      public int getAge () {
        return _age;
      }

      public void setAge(int age) {
        _age =  age;
      }

    }


}