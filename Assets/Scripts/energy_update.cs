using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energy_update : MonoBehaviour {
	private Image img_energy;
	private float img_energy_load_percent = 1.0f;
	private float last_update_time;
	public float energy_cost_rate = 0.01f;

	// Use this for initialization
	void Start () {
		this.img_energy = GetComponent<Image> ();
		this.img_energy.fillAmount = this.img_energy_load_percent;
		this.last_update_time = Time.time;

		Debug.Assert (this.energy_cost_rate > 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - this.last_update_time > 1f) {
			this.img_energy_load_percent -= this.energy_cost_rate;
			this.last_update_time = Time.time;
		}

		if (this.energy_cost_rate >= 0 && this.energy_cost_rate <= 1)
			this.img_energy.fillAmount = this.img_energy_load_percent;
	}
}
