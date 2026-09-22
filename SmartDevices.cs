using System;

public interface ISmartDevice 
{
	void TurnOn();
	void TurnOff();
	void GetStatus();
}

public class SmartLight : ISmartDevice 
{
	private bool status;
	public void TurnOn() 
	{
		Console.WriteLine("Smart Light is now ON.");
		status = true;
	}

	public void TurnOff() 
	{
		Console.WriteLine("Smart Light is now OFF.");
		status = false;
	}

	public void GetStatus() 
	{
		if (this.status == false) {
			Console.WriteLine("Smart Light is currently OFF.");
		}
		else {
			Console.WriteLine("Smart Light is currently ON.");
		}
	}
}

public class SmartThermostat : ISmartDevice 
{
	private bool status;
	public void TurnOn() 
	{
		Console.WriteLine("Smart Thermostat is now ON. Tmperature is set to 22*C");
		status = true;
	}

	public void TurnOff()
	{
		Console.WriteLine("Smart Thermostat is now OFF.");
		status = false;
	}

	public void GetStatus()
	{
		if (this.status == false) {
			Console.WriteLine("Smart Thermostat is currently OFF.");
		}
		else {
			Console.WriteLine("Smart Thermostat is currently ON.");
		}
	}
}

public class SmartDevices
{
	public static void Main(string[] args)
	{
		SmartLight sl = new SmartLight();
		SmartThermostat st = new SmartThermostat();
		sl.TurnOn();
		sl.GetStatus();
		sl.TurnOff();

		st.TurnOn();
		st.GetStatus();
		st.TurnOff();
	}
}
