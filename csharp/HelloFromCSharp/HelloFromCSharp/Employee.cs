
using Newtonsoft.Json;

namespace HelloFromCSharp
{
    public class Employee
	{

		public EmployeeType employeeType;
		const int minimalHoursWorked = 1;


		public Employee()
		{

		}


		public double ReceiveWage(bool resetHours = true) {
			return 1.0;
		}
		public string ConvertToJson()
		{
			string json = JsonConvert.SerializeObject(this);
			return json;

		}
	}
}

