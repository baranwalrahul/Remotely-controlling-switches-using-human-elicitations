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
 SerialPort sp = new SerialPort();
 sp.PortName = "com4";
 sp.BaudRate = 9600;
 sp.Open();
 sp.Write("d");
 sp.Close();
 }
 }
}
