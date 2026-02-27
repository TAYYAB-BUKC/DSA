namespace DSA.Basics.SeparateChaining
{
	public class Student
	{
		private int Id;
		private string Name;

		public Student(int id, string name)
		{
			Id = id;
			Name = name;
		}
		
		public int GetStudentId()
		{
			return Id;
		}

		public void SetStudentId(int i)
		{
			Id = i;
		}

		public new string ToString()
		{
			return $"{Id}) {Name}";
		}
	}
}