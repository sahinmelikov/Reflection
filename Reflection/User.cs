using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class User
    {
        public User()
        {
            
        }
        private int _id { get; set; }
        private string _name{ get; set; } 
        private string _surname { get; set; }
        private static int _age { get; set; }
  
        public void GetFulLName()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                Console.WriteLine("Name===========");
                Console.WriteLine(type.Name);
                Console.WriteLine("FullName=========");
                Console.WriteLine(type.FullName);
                //var fealds = type.GetFields(BindingFlags.Instance|BindingFlags.NonPublic);
                //foreach (var feald in fealds)
                //{
                //    Console.WriteLine(feald.Name);
                //    Console.WriteLine(feald);

                //}

            }

        }
       public static void ChangeAge(int age)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            foreach (var item in types)
            {
              _age = age;
                Console.WriteLine(age);
            
            }

        }

        public void UserInformation()
        {
            Console.WriteLine(_id+" "+_name+" "+_surname+" "+_age);
        }

    }
 


}
    

