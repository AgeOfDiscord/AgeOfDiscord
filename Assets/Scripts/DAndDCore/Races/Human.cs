namespace DAndDCore 
{
	public class Human : BaseRace
	{
		public Human (int age, int height, int weight)
			: base("Human", null, age, height, weight, 30, Size.Medium)
		{
			// TODO: two different ability scores of your choice increase by 1
		}
	}
}