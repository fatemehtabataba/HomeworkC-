﻿using System;

class Program
{

    public class bank
    {
        // موجودی
        double balance;

        // بهره بانکی
        double interest;

        // مبلغ مورد نظر
        double target;


        int years=0;

        public void Get_info()
        {
            Console.Write("enter your balance: ");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter interest percentage (integer): ");
            interest = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter target balance: ");
            target = Convert.ToDouble(Console.ReadLine());
        }
     
        public void years_to_target()
        {
            double target_balance = balance;
            while(target_balance < target)
            {
                target_balance = target_balance + (balance * (interest/100));
                years++;
            }
            Console.Write("years to target balance: {0}", years);
        }


    }
    static void Main(string[] args) {
        bank mybank = new bank();
        mybank.Get_info();
        mybank.years_to_target();
        Console.Read();
    }
}