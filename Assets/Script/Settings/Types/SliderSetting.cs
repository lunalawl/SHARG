using System;
using UnityEngine;

namespace YARG.Settings.Types {
	public class SliderSetting : AbstractSetting<float> {
		private float _data;
		public override float Data {
			get => _data;
			set {
				_data = Mathf.Clamp(value, Min, Max);
				base.Data = value;
			}
		}

		public override string AddressableName => "Setting/Slider";

		public float Min { get; private set; }
		public float Max { get; private set; }

		public SliderSetting(float value, float min = float.NegativeInfinity, float max = float.PositiveInfinity,
			Action<float> onChange = null) : base(onChange) {

			Min = min;
			Max = max;

			Data = value;
		}
	}
}