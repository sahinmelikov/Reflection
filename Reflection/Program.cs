using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.GetFulLName();
            User.ChangeAge(90);

            Type type = typeof(User);

            Console.WriteLine("Id=============================================");
            PropertyInfo prop_id = type.GetProperty("_id", BindingFlags.Instance | BindingFlags.NonPublic);
            prop_id.SetValue(user, 4);
            Console.WriteLine(prop_id.GetValue(user));

            Console.WriteLine("Name==========================================");
            PropertyInfo prop_name = type.GetProperty("_name", BindingFlags.Instance | BindingFlags.NonPublic);
            prop_name.SetValue(user, "Sahin");
            Console.WriteLine(prop_name.GetValue(user));

            Console.WriteLine("Surname==========================================");
            PropertyInfo prop_surname = type.GetProperty("_surname", BindingFlags.Instance | BindingFlags.NonPublic);
            prop_surname.SetValue(user, "Melikov");
            Console.WriteLine(prop_surname.GetValue(user));





            Console.WriteLine("Age==========================================");
            PropertyInfo prop_age = type.GetProperty("_age", BindingFlags.Instance | BindingFlags.NonPublic|BindingFlags.Static);
            prop_age.SetValue(null, 190);
            Console.WriteLine(prop_age.GetValue(null));


            MethodInfo methodget = type.GetMethod("UserInformation");
            methodget.Invoke(user, null);
        }
      
    }
}