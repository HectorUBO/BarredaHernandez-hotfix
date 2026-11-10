using System;
using Hernandez_Barreda_Hotfix;

Personaje personaje = new Personaje();

personaje.Nombre = "Mateo";
personaje.EstiloCombate = "Taekwondo";
personaje.Nivel = -1;
personaje.DanioAcumulado = 0;
personaje.Monedas = 100;

Console.WriteLine("DATOS DEL PERSONAJE");
Console.WriteLine($"Nombre: {personaje.Nombre}");
Console.WriteLine($"Estilo de combate: {personaje.EstiloCombate}");
Console.WriteLine($"Nivel: {personaje.Nivel}");
Console.WriteLine($"Daño acumulado: {personaje.DanioAcumulado}%");
Console.WriteLine($"Monedas: {personaje.Monedas}");