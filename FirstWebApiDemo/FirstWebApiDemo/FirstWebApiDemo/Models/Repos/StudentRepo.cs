namespace FirstWebApiDemo.Models.Repos
{
    public class StudentRepo : IRepos<Student>
    {
        public static List<Student> studList = null;

        public StudentRepo()
        {
            if (studList == null)
            {
                studList = new List<Student>()
                {
                    new Student(){RollNo=1, Name="John", City="New York", PhoneNumber="1234567890"},
                    new Student(){RollNo=2, Name="Jane", City="Los Angeles", PhoneNumber="0987654321"},
                    new Student(){RollNo=3, Name="Bob", City="Chicago", PhoneNumber="5555555555"}
                };
            }
        }
        public bool Add(Student item)
        {
            bool flag = false;
            if(item != null)
            {
                studList.Add(item);
                flag = true;
            }
            return flag;
        }

        public bool Delete(Student item)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            var student = studList.Find(x => x.RollNo == id);
            if(student != null)
            {
                return student;
            }
            else
            {
                throw new Exception("Student not found");
            }
        }

        public ICollection<Student> GetAll()
        {
            return studList;
        }

        public bool Update(int id, Student item)
        {
            bool flag = false;
            var existingStudent = studList.Find(x => x.RollNo == id);
            if (existingStudent != null && item != null)
            {
                existingStudent.Name = item.Name;
                existingStudent.City = item.City;
                existingStudent.PhoneNumber = item.PhoneNumber;
                flag = true;
            }
            else
            {
                throw new Exception("Student not found");
            }
            return flag;
        }
    }
}
