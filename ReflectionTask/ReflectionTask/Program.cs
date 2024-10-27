using System.Reflection;

namespace ReflectionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type userType = assembly.GetType("ReflectionExample.User"); 

            // Obyekt yaratmaq üçün 'Activator.CreateInstance' dən istifadə etməliyik demeəli search edəndə öyrəndim bunu
            object userInstance = Activator.CreateInstance(userType);

            var fields = new (string name, object value)[]
            {
                ("id", 1),
                ("name", "Mahir"),
                ("soyad", "Xəlilov"),
                ("age", 45) // 'age' statik sahədir, instance istəmir ona gorə .static yazılacaq
            };

            foreach (var field in fields)
            {
                FieldInfo fieldInfo = userType.GetField(field.name, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                fieldInfo?.SetValue(fieldInfo.IsStatic ? null : userInstance, field.value);
            }

            { }



            foreach (var field in fields)
            {
                FieldInfo fieldInfo = userType.GetField(field.name, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                Console.WriteLine($"{field.name}: {fieldInfo?.GetValue(fieldInfo.IsStatic ? null : userInstance)}");
            }

//Method hissəsi
            userType.GetMethod("GetFullName", BindingFlags.Public | BindingFlags.Instance)?.Invoke(userInstance, null);
            userType.GetMethod("ChangeAge", BindingFlags.Public | BindingFlags.Static)?.Invoke(null, new object[] { 30 });

            
            FieldInfo ageField = userType.GetField("age", BindingFlags.NonPublic | BindingFlags.Static);
            Console.WriteLine("New age: " + ageField?.GetValue(null));
        }


    }


 
}