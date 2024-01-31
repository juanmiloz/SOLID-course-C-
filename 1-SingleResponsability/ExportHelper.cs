using System.Collections;
using System.Reflection;
using System.Text;

namespace SingleResponsability;

public class ExportHelper{

    public void exportStudents(IEnumerable<Student> students){
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.AppendLine("Id;Fullname;Grades");
        foreach (var item in students)
        {
            sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
        }
        System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);


        // Type type = listToExport.First().GetType();
        // PropertyInfo[] properties = type.GetProperties();

        // sb.AppendLine(String.Join(";", properties.Select(x => x.Name)));

        // int counter;
        // string csvRow;
        // foreach (var item in listToExport)
        // {
        //     csvRow = "";
        //     foreach(var property in item.GetType().GetProperties()){
        //         csvRow += property.GetValue(item)+";";    
        //     }
        //     Console.WriteLine(csvRow);
        // }
        // System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);
    }

}