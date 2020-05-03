//Program for closing the door

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.IO;

namespace ConsoleApplication1
{
 class doorClose
 {
 static void Main(string[] args)
 {
  //SerialPort class allows communication with a serial port
  //sp is the object of class SerialPort
 SerialPort sp = new SerialPort();
  
  //Specifying the port name
 sp.PortName = "com4";
  
  //Baud rate : rate at which information is transferred
 sp.BaudRate = 9600;
  
  //Open the serial port
 sp.Open();
  
  //Writing "a" to cmd
 sp.Write("a");
  
  //Closing the serial port
 sp.Close();
  
 }
  
 }
 
}
