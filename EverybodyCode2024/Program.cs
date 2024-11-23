﻿// See https://aka.ms/new-console-template for more information

using EverybodyCode2024;
using AOC;
using System.Reflection;

BaseDay.Year = "2024";
BaseDay.InputDir = Path.Combine(Directory.GetCurrentDirectory(), "Input", "EverybodyCodes", BaseDay.Year + Path.DirectorySeparatorChar.ToString());

Runner days = new Runner(Assembly.GetExecutingAssembly());

//tests
{
    days[0].AddTestInput(["ABBAC"], "5");
    days[0].AddTestInput(["AxBCDDCAxD"], "", "28");
    days[0].AddTestInput(["xBxAAABCDxCC"], "", "", "30");

    days[1].AddTestInput(["WORDS:THE,OWE,MES,ROD,HER",
        "",
        "AWAKEN THE POWER ADORNED WITH THE FLAMES BRIGHT IRE"], "4");
    days[1].AddTestInput([
        "WORDS:THE,OWE,MES,ROD,HER,QAQ",
        "",
        "AWAKEN THE POWE ADORNED WITH THE FLAMES BRIGHT IRE",
        "THE FLAME SHIELDED THE HEART OF THE KINGS",
        "POWE PO WER P OWE R",
        "THERE IS THE END",
        "QAQAQ"
        ], "", "42");

    days[1].AddTestInput([
        "WORDS:THE,OWE,MES,ROD,RODEO",
        "",
        "HELWORLT",
        "ENIGWDXL",
        "TRODEOAL"
        ], "", "", "10");


    // days[1].AddTestInput([
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     ""
    //     ], "", "", "");
}

////run
Console.WriteLine("Running");
days.RunLatest();

////run all
Console.WriteLine("Running All");
days.RunAll();

//windows closes the console window, linux does not
//keep open on windows
Helpers.ConsoleReadKeyWindows();