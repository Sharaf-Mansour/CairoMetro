﻿global using Microsoft.AspNetCore.Components.Web;
global using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
global using CairoMetro;
global using System;
global using CairoMetro.Model;
namespace CairoMetro;
public static class Loaders
{
    public static Span<Station> Map => new Station[]
    {
        new(19, "Sadat", Line.Line2, "top:50.2%; left:47.95%;", true),
        new(21, "Ataba", Line.Line3, "top:45.1%; left:18.7%;", true),
        new(22, "Al-Shohadaa", Line.Line2, "top:42.5%; left:48%;", true),
        new(20, "Nasser", Line.Line1, "top:48.35%; left:30.9%;", true),
        // Switchers complete
        new(1, "Helwan", Line.Line1, "top:96.7%; left:65.45%;"),
        new(2, "Ain Helwan", Line.Line1, "top:94.65%; left:65.45%;"),
        new(3, "Helwan University", Line.Line1, "top:91.95%; left:65.45%;"),
        new(4, "Wadi Hof", Line.Line1, "top:89.25%; left:65.45%;"),
        new(5, "Hadayek Helwan", Line.Line1, "top:86.9%; left:65.45%;"),
        new(6, "El-Maasara", Line.Line1, "top:84.2%; left:65.45%;"),
        new(7, "Tora El-Asmant", Line.Line1, "top:81.8%; left:65.45%;"),
        new(8, "Kozzika", Line.Line1, "top:79.25%; left:65.45%;"),
        new(9, "Tora El-Balad", Line.Line1, "top:76.8%; left:65.45%;"),
        new(10, "Sakanat El-Maadi", Line.Line1, "top:74.45%; left:65.45%;"),
        new(11, "Maadi", Line.Line1, "top:71.55%; left:65.20%;"),
        new(12, "Hadayek El-Maadi", Line.Line1, "top:68.85%; left:65.45%;"),
        new(13, "Dar El-Salam", Line.Line1, "top:66.45%; left:65.45%;"),
        new(14, "El-Zahraa'", Line.Line1, "top:63.75%; left:65.45%;"),
        new(15, "Mar Girgis", Line.Line1, "top:61%; left:65.45%;"),
        new(16, "El-Malek El-Saleh", Line.Line1, "top:58.15%; left:65.45%;"),
        new(17, "Al-Sayeda Zeinab", Line.Line1, "top:55.2%; left:65.45%;"),
        new(18, "Saad Zaghloul", Line.Line1, "top:52.75%; left:65.45%;"),
        new(21, "Orabi", Line.Line1, "top:45%; left:65.45%;"),
        new(23, "Ghamra", Line.Line1, "top:40%; left:65.45%;"),
        new(24, "El-Demerdash", Line.Line1, "top:37.65%; left:65.45%;"),
        new(25, "Manshiet El-Sadr", Line.Line1, "top:34.95%; left:65.45%;"),
        new(26, "Kobri El-Qobba", Line.Line1, "top:32.6%; left:65.45%;"),
        new(27, "Hammamat El-Qobba", Line.Line1, "top:29.8%; left:65.45%;"),
        new(28, "Saray El-Qobba", Line.Line1, "top:26.6%; left:65.45%;"),
        new(29, "Hadayeq El-Zaitoun", Line.Line1, "top:24.25%; left:65.45%;"),
        new(30, "Helmeyet El-Zaitoun", Line.Line1, "top:21.55%; left:65.45%;"),
        new(31, "El-Matareyya", Line.Line1, "top:19.2%; left:65.45%;"),
        new(32, "Ain Shams", Line.Line1, "top:16.5%; left:65.45%;"),
        new(33, "Ezbet El-Nakhl", Line.Line1, "top:14.15%; left:65.45%;"),
        new(34, "El-Marg", Line.Line1, "top:11.4%; left:65.45%;"),
        new(35, "New El-Marg", Line.Line1, "top:9%; left:65.45%;"),
        //Line ONE Complete          
        new(10, "El-Mounib", Line.Line2, "top:75.6%; left:36.2%;"),
        new(11, "Sakiat Mekky", Line.Line2, "top:72.75%; left:36.2%;"),
        new(12, "Omm El-Masryeen", Line.Line2, "top:69.95%; left:36.2%;"),
        new(13, "Giza", Line.Line2, "top:67%; left:36.2%;"),
        new(14, "Faisal", Line.Line2, "top:64.2%; left:36.2%;"),
        new(15, "Cairo University", Line.Line2, "top:61.4%; left:36.2%;"),
        new(16, "El Bohoth", Line.Line2, "top:58.6%; left:36.2%;"),
        new(17, "Dokki", Line.Line2, "top:55.7%; left:36.2%;"),
        new(18, "Opera", Line.Line2, "top:52.8%; left:36.2%;"),
        new(20, "Mohamed Naguib", Line.Line2, "top:46.8%; left:36.2%;"),
        new(23, "Masarra", Line.Line2, "top:39.7%; left:36.2%;"),
        new(24, "Rod El-Farag", Line.Line2, "top:36.8%; left:36.2%;"),
        new(25, "St. Teresa", Line.Line2, "top:34%; left:36.2%;"),
        new(26, "Khalafawy", Line.Line2, "top:31.15%; left:36.2%;"),
        new(27, "Mezallat", Line.Line2, "top:28.3%; left:36.2%;"),
        new(28, "Kolleyyet El-Zeraa", Line.Line2, "top:25.45%; left:36.2%;"),
        new(29, "Shubra El-Kheima", Line.Line2, "top:22.4%; left:36.2%;"),
        //Line TWO Complete             
        new(39, "Adly Mansour", Line.Line3, "top:1%; left:4.55%;"),
        new(38, "Hikestep", Line.Line3, "top:3.5%; left:4.55%;"),
        new(37, "Omar ibn Al-khattab", Line.Line3, "top:5.6%; left:4.55%;"),
        new(36, "Kebaa", Line.Line3, "top:8%; left:4.55%;"),
        new(35, "Hisham Barakat", Line.Line3, "top:10.5%; left:4.55%;"),
        new(34, "El-Nozha", Line.Line3, "top:12.95%; left:4.55%;"),
        new(33, "El-Shams Club", Line.Line3, "top:15%; left:4.55%;"),
        new(32, "Alf Masken", Line.Line3, "top:17.65%; left:4.55%;"),
        new(31, "Heliopolis Square", Line.Line3, "top:19.95%; left:4.55%;"),
        new(30, "Haroun", Line.Line3, "top:22.45%; left:4.55%;"),
        new(29, "Al-Ahram", Line.Line3, "top:24.9%; left:4.55%;"),
        new(28, "Koleyet El Banat", Line.Line3, "top:27.4%; left:4.55%;"),
        new(27, "Cairo Stadium", Line.Line3, "top:29.85%; left:4.55%;"),
        new(26, "Fair Zone", Line.Line3, "top:32.35%; left:4.55%;"),
        new(25, "Abbassia", Line.Line3, "top:34.8%; left:4.55%;"),
        new(24, "Abdou Pasha", Line.Line3, "top:37.3%; left:4.55%;"),
        new(23, "El Geish", Line.Line3, "top:39.7%; left:4.55%;"),
        new(22, "Bab El Shaaria", Line.Line3, "top:42.2%; left:4.55%;"),
        new(19, "Bab El Shaaria", Line.Line3, "top:50%; left:4.55%;"),
        new(18, "Bab El Shaaria", Line.Line3, "top:52%; left:4.55%;"),
        new(17, "Bab El Shaaria", Line.Line3, "top:54.5%; left:4.55%;")
        //Line THREE Complete
    };
}