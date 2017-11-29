﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server
{
	public class SampleService : ISampleService
	{
		public string Ping(string s)
		{
			Console.WriteLine("Exec ping method");
			return s;
		}

		public ComplexModelResponse PingComplexModel(ComplexModelInput inputModel)
		{
			Console.WriteLine("Input data. IntProperty: {0}, StringProperty: {1}", inputModel.IntProperty, inputModel.StringProperty);
			return new ComplexModelResponse
			{
				FloatProperty = float.MaxValue / 2,
				StringProperty = Guid.NewGuid().ToString()
			};
		}
	}
}