using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain;

namespace Database.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasData(
            new Student
            {
                StudentId = 1,
                Name = "Ayan"
            },
            new Student
            {
                StudentId = 2,
                Name = "Sayan"
            },
            new Student
            {
                StudentId = 3,
                Name = "Nayan"
            },
            new Student
            {
                StudentId = 4,
                Name = "Chayan"
            },
            new Student
            {
                StudentId = 5,
                Name = "Ayantika"
            }
        );
    }

    }
}