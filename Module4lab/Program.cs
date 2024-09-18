﻿//Application Name : Rocket Launch
//Deverloper: Dr. Mary lebands
//Description: Simulates a rocket launch using loops.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
 
namespace RocketLaunchApp {
     class Program {

       static void Main(string[]args){
        //Greet the user
        Console.WriteLine("Welcome to Rocket Countdown");
        Console.WriteLine("Get ready for liftoff!");

        //countdown using for loop
        for(int i = 30 ; i >= 2; i--)
        {
            //show the current place in the countdown to user
            Console.WriteLine($"T-{i}seconds...");

            //wait for 1 seconds
            Thread.Sleep(1000);
        }//end for loop
       //start the ignition sequence
       Console.WriteLine("ignition sequence start!");
       Console.WriteLine("Engines aew firing...");

       //countdownt using a white loop
       int countdown = 5;
       while(countdown > 0){
         //output the number of seconds for liftoff
         Console.WriteLine($"t-{countdown} seconds...");
         Thread.Sleep(1000); //wait for 1 second
         //Decrement the countdow variable
         countdown--;
       }//end white loop

       //Liftoff
       Console.WriteLine("Liftoff! The rocket is on its way to space!");
       Console.WriteLine("Mission accomplished .Have a stellar day!");
       
       //Simulate the rocket ascent
       for (int altitude = 0 ; altitude <= 100; altitude += 10){
        //Output for altitude 
        Console.WriteLine($"Altitude: {altitude} km");
        Thread.Sleep(500);//wait for haft a second
       }


       
       }//end main method
    }//end Program class
}//end namespace
