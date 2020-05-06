//Opening the door
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.IO;
namespace ConsoleApplication1
{
 class doorOpen
 {
 static void Main(string[] args)
 {
  
 //SerialPort class to communicate with the serial ports
 SerialPort sp = new SerialPort();
  
 //Specifying the name of the serial port
 sp.PortName = "com4";
  
 //Baud rate to determine the speed of communication 
 sp.BaudRate = 9600;
  
 //Openinng the serial port connection 
 sp.Open();
  
 //Writing "d" to command line 
 sp.Write("d");
  
 //Closing the serial port connection 
 sp.Close();
  
 }
  
 }
 
}
