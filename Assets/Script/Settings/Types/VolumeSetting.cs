using System;
using UnityEngine;

namespace YARG.Settings.Types {
	public class VolumeSetting : AbstractSetting<float> {
		private float _data;

		public override float Data {
			get => _data;
			set {
				_data = Mathf.Clamp(value, 0, 1);
				base.Data = value;
			}
		}

		public override string AddressableName => "Setting/Volume";

		public VolumeSetting(float data, Action<float> onChange = null) : base(onChange) {
			Data = data;
		}
	}
}