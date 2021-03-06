﻿using System;

namespace SmartLife.Interfaces
{
	public interface ILuxMeasure : IMeasure
	{
		event EventHandler<MeasurementReport<float>> LuxMeasurementTaken;
	}

	public class LuxMeasureReport : MeasurementReport<float>
	{
		public LuxMeasureReport(float value, string unit)
			: base(ReportType.Lux, value, unit) { }
	}
}