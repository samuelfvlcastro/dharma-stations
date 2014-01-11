using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System.Threading;

public class ArduinoConnection : MonoBehaviour {
    
	public static SerialPort sp = new SerialPort("COM3", 9600);
	public string message2;
	float timePassed = 0.0f;
	
	private static bool isOn = false;

	void Start () {
		OpenConnection();
	}
	
	void Update () {
	
	}

	public void OpenConnection() 
    {
       if (sp != null) 
       {
         if (sp.IsOpen) 
         {
          sp.Close();
          print("Closing port, because it was already open!");
         }
         else 
         {
          sp.Open();
          sp.ReadTimeout = 16; 
          print("Port Opened!");
         }
       }
       else 
       {
         if (sp.IsOpen)
         {
          print("Port is already open");
         }
         else 
         {
          print("Port == null");
         }
       }
    }

    void OnApplicationQuit() 
    {
	   sp.WriteLine("5");
       sp.Close();
    }

    public void sendLightningStrike(){
    	sp.WriteLine("1");
    }

    public  void sendGreenHealth(){
    	sp.WriteLine("2");
    }
	
    public  void sendOrangeHealth(){
    	sp.WriteLine("3");
    }
	
    public  void sendRedHealth(){
    	sp.WriteLine("4");
    }
	
		
    public void sendFanControl(int power){
    	sp.WriteLine(power.ToString());
		
    }
}
