﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator
{
    class Program
    {
        static void Main(string[] args)
        {

            Laboratory lab = new Laboratory();

            Laboratory.Chief chief = new Laboratory.Chief("Peter", "Mrkvicka");

            lab.app1 = new Microscope("zooming");
            lab.app1.appNum = 10;
            lab.app1.turnOn();

            lab.app2 = new Centrifuge("centrifuging");
            lab.app2.appNum = 20;

            

            string running = (lab.app1.state) ? "is running" : "is turned off";

            Console.WriteLine("Appliance: {0} {1} and the id number is {2}, function:{3}", lab.app1.GetDetailApplianceInfo(),running, lab.app1.appNum.ToString(), lab.app1.getApplFunction());
            running = (lab.app2.state) ? "is running" : "is turned off";

            Console.WriteLine("Appliance: {0} {1} and the id number is {2}, function:{3}", lab.app2.GetDetailApplianceInfo(), running, lab.app2.appNum.ToString(),lab.app2.getApplFunction());

            Console.WriteLine(" The name of chief of the lab is: {0}", chief.getFullName());

            Console.WriteLine("Let the science begin...");

            Console.WriteLine("***************************************************************");

            var app = Lab2.Init("microscope");
            app.turnOn();

            running = (app.state) ? "is running" : "is turned off";

            Console.WriteLine("Appliance: {0} {1} and the id number is {2}, function:{3}", app.GetDetailApplianceInfo(), running, app.appNum.ToString(), app.getApplFunction());


            var app1 = Lab2.Init("centrifuge");
            app1.turnOff();

            running = (app1.state) ? "is running" : "is turned off";

            Console.WriteLine("Appliance: {0} {1} and the id number is {2}, function:{3}", app1.GetDetailApplianceInfo(), running, app1.appNum.ToString(), app1.getApplFunction());

            chief.setFullName("Jozko", "Zeleny");

            Console.WriteLine("Veduci sa zmenil na: {0}", chief.getFullName());


            Console.ReadKey();


        }
    }
}
