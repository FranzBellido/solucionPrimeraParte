﻿// See https://aka.ms/new-console-template for more information



using System.Globalization;

DateTime mifecha = new DateTime(2023, 1, 26,16,15,20,DateTimeKind.Utc);

var dia = mifecha.Day;
var mes = mifecha.Month;

var diasemana = mifecha.DayOfWeek;


CultureInfo CurrentCulture = new CultureInfo("en-US");


var fechastr = "10/22/2015 12:10:15";

DateTime fecha2 = Convert.ToDateTime(fechastr, CurrentCulture);


var fecha3 = fecha2.AddDays(-2);
var fecha4 = fecha3.AddMonths(-2);


TimeSpan periodo1 = new TimeSpan(1, 15, 30);

DateTime fecha5 =fecha3+periodo1;


int comparacion = DateTime.Compare(fecha3, fecha5);

int comp =fecha5.CompareTo(fecha4);

Console.WriteLine(fecha5.ToShortDateString());

Console.WriteLine(fecha5.ToLongDateString());
Console.WriteLine(fecha5.ToString());




//Console.WriteLine(comparacion);