namespace CounterweightCalculator.Pages.Data;

public class Counterweight {
    public float counterweight_mass_raw;
    public string counterweight_mass_units = "Kg";
    public float counterweight_mass_kg => counterweight_mass_raw * Index.weight_conversions[counterweight_mass_units];
    public float counterweight_mass_N => counterweight_mass_kg * Index.gravity_acceleration;
    public float counterweight_distance_raw {get; set;}
    public string counterweight_distance_units = "cm";
    public float counterweight_distance_m => counterweight_distance_raw * Index.distance_conversions[counterweight_distance_units];
}