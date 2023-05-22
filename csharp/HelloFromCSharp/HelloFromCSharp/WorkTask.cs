using System;
namespace HelloFromCSharp
{
	internal struct WorkTask //structs are stored in the stack, rather than on the heap.
	{
		public string description;
		public int hours;

		public void PeroformWorkTask()
		{
			Console.WriteLine($"Task {description} performed!");

		}
	}
}

