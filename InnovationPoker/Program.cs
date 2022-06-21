// See https://aka.ms/new-console-template for more information

using InnovationPoker;
using InnovationPoker.Entities;

Console.WriteLine("Hello, World!");

var playPoker = new PlayPoker();
var player= playPoker.Game(new Play(), new Play());

Console.WriteLine("Winner:" + player.ToString());
