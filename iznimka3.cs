using System;
using System.IO;
class FinallyDemo
{
 static void Main(string[] args)
 {
 FileStream outStream = null;
 FileStream inStream = null;
 try
 {
 outStream = File.OpenWrite("Izlazna_datoteka.txt");
 inStream = File.OpenRead("Nepostojeca_Datoteka.txt");
 }
 catch (Exception ex)
 {
 Console.WriteLine(ex.ToString());
 }
 finally
 {
 if (outStream != null)
 {
 outStream.Close();
 Console.WriteLine("outStream zatvoren.");
 }
 if (inStream != null)
 {
 inStream.Close();
 Console.WriteLine("inStream zatvoren.");
 }
 }
 }
} 
