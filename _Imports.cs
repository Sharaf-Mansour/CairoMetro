global using Microsoft.AspNetCore.Components.Web;
global using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
global using CairoMetro;
global using System.Collections.Generic;
global using System;
global using System.Text.RegularExpressions;
global using System.Text.Json;
global using Microsoft.AspNetCore.Components.Forms;
global using Microsoft.AspNetCore.Components;
global using System.Net.Http.Json;
global using CairoMetro.Model;

namespace CairoMetro;
public static class Loaders
{

    public static Span<Station> Map => new Station[]
    {
        new(19, "Sadat", Line.Line2, "top:50.47%; left:49.04%;",true),
        new(21, "Ataba", Line.Line3, "top:45.40%; left:19.50%;",true),
        new(22, "Al-Shohadaa", Line.Line2, "top:42.73%; left:49.04%;",true),
        new(19, "Sadat", Line.Line1, "top:50.47%; left:49.04%;",true),
        new(21, "Ataba", Line.Line2, "top:45.40%; left:19.50%;",true),
        new(22, "Al-Shohadaa", Line.Line1, "top:42.73%; left:49.04%;",true),  
           
        //Shwitchers

        new(1, "Helwan", Line.Line1, "top:96.88%; left:66.33%;"),
        new(2, "Ain Helwan", Line.Line1, "top:94.86%; left:66.33%;"),
        new(3, "Helwan University", Line.Line1, "top:92.15%; left:66.33%;"),
        new(4, "Wadi Hof", Line.Line1, "top:89.45%; left:66.33%;"),
        new(5, "Hadayek Helwan", Line.Line1, "top:87.09%; left:66.33%;"),
        new(6, "El-Maasara", Line.Line1, "top:84.39%; left:66.33%;"),
        new(7, "Tora El-Asmant", Line.Line1, "top:82.04%; left:66.33%;"),
        new(8, "Kozzika", Line.Line1, "top:79.45%; left:66.33%;"),
        new(9, "Tora El-Balad", Line.Line1, "top:77.08%; left:66.33%;"),
        new(10, "Sakanat El-Maadi", Line.Line1, "top:74.65%; left:66.33%;"),
        new(11, "Maadi", Line.Line1, "top:71.74%; left:66.33%;"),
        new(12, "Hadayek El-Maadi", Line.Line1, "top:69.07%; left:66.33%;"),
        new(13, "Dar El-Salam", Line.Line1, "top:66.66%; left:66.33%;"),
        new(14, "El-Zahraa'", Line.Line1, "top:63.95%; left:66.33%;"),
        new(15, "Mar Girgis", Line.Line1, "top:61.21%; left:66.33%;"),
        new(16, "El-Malek El-Saleh", Line.Line1, "top:58.35%; left:66.33%;"),
        new(17, "Al-Sayeda Zeinab", Line.Line1, "top:55.39%; left:66.33%;"),
        new(18, "Saad Zaghloul", Line.Line1, "top:52.94%; left:66.33%;"),
        new(20, "Nasser", Line.Line1, "top:47.69%; left:66.33%;"),
        new(21, "Orabi", Line.Line1, "top:45.22%; left:66.33%;"),
        new(23, "Ghamra", Line.Line1, "top:40.19%; left:66.33%;"),
        new(24, "El-Demerdash", Line.Line1, "top:37.84%; left:66.33%;"),
        new(25, "Manshiet El-Sadr", Line.Line1, "top:35.14%; left:66.33%;"),
        new(26, "Kobri El-Qobba", Line.Line1, "top:32.79%; left:66.33%;"),
        new(27, "Hammamat El-Qobba", Line.Line1, "top:30.02%; left:66.33%;"),
        new(28, "Saray El-Qobba", Line.Line1, "top:26.81%; left:66.33%;"),
        new(29, "Hadayeq El-Zaitoun", Line.Line1, "top:24.45%; left:66.33%;"),
        new(30, "Helmeyet El-Zaitoun", Line.Line1, "top:21.75%; left:66.33%;"),
        new(31, "El-Matareyya", Line.Line1, "top:19.40%; left:66.33%;"),
        new(32, "Ain Shams", Line.Line1, "top:16.70%; left:66.33%;"),
        new(33, "Ezbet El-Nakhl", Line.Line1, "top:14.35%; left:66.33%;"),
        new(34, "El-Marg", Line.Line1, "top:11.58%; left:66.33%;"),
        new(35, "New El-Marg", Line.Line1, "top:09.25%; left:66.33%;"),
        //Line ONE Complete
               
        new(10, "El-Mounib", Line.Line2, "top:75.79%; left:37.13%;"),
        new(11, "Sakiat Mekky", Line.Line2, "top:72.94%; left:37.13%;"),
        new(12, "Omm El-Masryeen", Line.Line2, "top:70.07%; left:37.13%;"),
        new(13, "Giza", Line.Line2, "top:67.19%; left:37.13%;"),
        new(14, "Faisal", Line.Line2, "top:64.37%; left:37.13%;"),
        new(15, "Cairo University", Line.Line2, "top:61.62%; left:37.13%;"),
        new(16, "El Bohoth", Line.Line2, "top:58.78%; left:37.13%;"),
        new(17, "Dokki", Line.Line2, "top:55.93%; left:37.13%;"),
        new(18, "Opera", Line.Line2, "top:53.06%; left:37.13%;"),
        new(20, "Mohamed Naguib", Line.Line2, "top:47.81%; left:37.13%;"),
        new(23, "Masarra", Line.Line2, "top:39.91%; left:37.13%;"),
        new(24, "Rod El-Farag", Line.Line2, "top:37.07%; left:37.13%;"),
        new(25, "St. Teresa", Line.Line2, "top:34.22%; left:37.13%;"),
        new(26, "Khalafawy", Line.Line2, "top:31.35%; left:37.13%;"),
        new(27, "Mezallat", Line.Line2, "top:28.52%; left:37.13%;"),
        new(28, "Kolleyyet El-Zeraa", Line.Line2, "top:25.65%; left:37.13%;"),
        new(29, "Shubra El-Kheima", Line.Line2, "top:22.67%; left:37.13%;"),
        //Line TWO Complete
               
        new(3, "Adly Mansour", Line.Line3, "top:01.35%; left:05.57%;"),
        new(4, "Hikestep", Line.Line3, "top:03.81%; left:05.57%;"),
        new(5, "Omar ibn Al-khattab", Line.Line3, "top:05.88%; left:05.57%;"),
        new(6, "Kebaa", Line.Line3, "top:08.28%; left:05.57%;"),
        new(7, "Hisham Barakat", Line.Line3, "top:10.79%; left:05.57%;"),
        new(8, "El-Nozha", Line.Line3, "top:13.25%; left:05.57%;"),
        new(9, "El-Shams Club", Line.Line3, "top:15.32%; left:05.57%;"),
        new(10, "Alf Masken", Line.Line3, "top:17.83%; left:05.57%;"),
        new(11, "Heliopolis Square", Line.Line3, "top:20.25%; left:05.57%;"),
        new(12, "Haroun", Line.Line3, "top:22.76%; left:05.57%;"),
        new(13, "Al-Ahram", Line.Line3, "top:25.21%; left:05.57%;"),
        new(14, "Koleyet El Banat", Line.Line3, "top:27.72%; left:05.57%;"),
        new(15, "Cairo Stadium", Line.Line3, "top:30.14%; left:05.57%;"),
        new(16, "Fair Zone", Line.Line3, "top:32.65%; left:05.57%;"),
        new(17, "Abbassia", Line.Line3, "top:35.09%; left:05.57%;"),
        new(18, "Abdou Pasha", Line.Line3, "top:37.60%; left:05.57%;"),
        new(19, "El Geish", Line.Line3, "top:40.02%; left:05.57%;"),
        new(20, "Bab El Shaaria", Line.Line3, "top:42.53%; left:05.57%;"),
        //Line THREE Complete

    };
}
