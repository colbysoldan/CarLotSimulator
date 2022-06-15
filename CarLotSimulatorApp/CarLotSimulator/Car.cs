using System;
namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{
			CarLot.numberOfCars++;
		}

		public Car(string make,
					string model,
					int year,
					string engineNoise,
					string honkNoise,
					bool isDrivable)
        {
			Year = year;
			Model = model;
			Make = make;
			EngineNoise = engineNoise;
			HonkNoise = honkNoise;
			IsDrivable = isDrivable;
        }

		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public bool IsDrivable { get; set; }

		public void MakeHonkNoise()
        {
			Console.WriteLine(HonkNoise);
        }

		public void MakeEngineNoise()
        {
			Console.WriteLine(EngineNoise);
        }
	}
}

