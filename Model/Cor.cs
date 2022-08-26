using System;

static class Cor{
  public static ConsoleColor DarkRed(){
    ConsoleColor foreground = Console.ForegroundColor;
    return Console.ForegroundColor = ConsoleColor.DarkRed;
  }
  public static ConsoleColor DarkBlue(){
    ConsoleColor foreground = Console.ForegroundColor;
    return Console.ForegroundColor = ConsoleColor.DarkBlue;
  }
  public static ConsoleColor Yellow(){
    ConsoleColor foreground = Console.ForegroundColor;
    return Console.ForegroundColor = ConsoleColor.Yellow;
  }
  public static ConsoleColor White(){
    ConsoleColor foreground = Console.ForegroundColor;
    return Console.ForegroundColor = ConsoleColor.White;
  }
  public static ConsoleColor Green(){
    ConsoleColor foreground = Console.ForegroundColor;
    return Console.ForegroundColor = ConsoleColor.Green;
  }
  public static ConsoleColor Magenta(){
    ConsoleColor foreground = Console.ForegroundColor;
    return Console.ForegroundColor = ConsoleColor.Magenta;
  }
}