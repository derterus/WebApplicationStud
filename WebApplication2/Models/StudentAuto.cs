using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication2.Data;
using System;
using System.Linq;
using System.IO;
namespace WebApplication2.Models
{
    public static class StudentAuto
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StudentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<StudentContext>>()))
            {
               
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }
                List<string> list = new List<string>(File.ReadAllLines(@"wwwroot\DataForSite\Student.txt"));
                for (int i = 0; i < list.Count; i++)
                {
                    List<string> line = new List<string>(list[i].Split(','));
                    context.Student.Add(
                        new Student
                        {
                            SecondName = line[0],
                            Name = line[1],
                            Surname = line[2],
                            Height = Convert.ToInt32(line[3]),
                            BirthDay = $"{line[4]}",
                            Group = line[5],
                            Speciality =line[6],
                            Scholarship = Convert.ToInt32(line[7]),

                        }
                    );

                }
                context.SaveChanges();
            }
        }
    }
}
