//using System;

//namespace C_class
//{
//    public class SmartDevice
//    {
//        public interface ISmartDevice
//        {
//            void On();
//            void Off();
//            void GetStatus();
//        }
//        public class SmartThermostat : ISmartDevice
//        {
//            string? status = "OFF";
//            public void On()
//            {
//                Console.WriteLine("Thermostat is ON: Temp is set to 71°F");
//                status = "ON";
//            }
//            public void Off()
//            {
//                Console.WriteLine("Thermostat is OFF");
//                status = "OFF";
//            }
//            public void GetStatus()
//            {
//                Console.WriteLine("Thermostat is currently {0}", status);
//            }
//        }
//        public class SmartLight : ISmartDevice
//        {
//            string? status = "OFF";
//            public void On()
//            {
//                Console.WriteLine("Light is ON");
//                status = "ON";
//            }
//            public void Off()
//            {
//                Console.WriteLine("Light is OFF");
//                status = "OFF";
//            }
//            public void GetStatus()
//            {
//                Console.WriteLine("Light is currently {0}", status);
//            }
//        }
//        static void Main(string[] args)
//        {
//            ISmartDevice s;
//            while (true)
//            {
//                string? device = Console.ReadLine();
//                if (device == "t")
//                {
//                    s = new SmartThermostat();
//                    while (true)
//                    {
//                        string? status = Console.ReadLine();
//                        if (status == "on")
//                        {
//                            s.On();
//                        }
//                        else if (status == "off")
//                        {
//                            s.Off();
//                        }
//                        else if (status == "status")
//                        {
//                            s.GetStatus();
//                        }
//                        else
//                        {
//                            Console.WriteLine("Returning to menu");
//                            break;
//                        }
//                    }
//                }

//                else if (device == "l")
//                {
//                    s = new SmartLight();
//                    while (true)
//                    {
//                        string? status = Console.ReadLine();
//                        if (status == "on")
//                        {
//                            s.On();
//                        }
//                        else if (status == "off")
//                        {
//                            s.Off();
//                        }
//                        else if (status == "status")
//                        {
//                            s.GetStatus();
//                        }
//                        else
//                        {
//                            Console.WriteLine("Returning to menu");
//                            break;
//                        }
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Exiting");
//                    break;
//                }
//            }
//        }
//    }
//}
