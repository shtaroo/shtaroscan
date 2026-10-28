using System;
using System.Net.Sockets;

Console.Clear();

PrintWelcomeMessage();

Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

socket.Connect("scanme.nmap.org", 80);

void PrintWelcomeMessage() {
    Console.WriteLine("""
                   /$$         /$$
                  | $$        | $$
          /$$$$$$$| $$$$$$$  /$$$$$$    /$$$$$$   /$$$$$$   /$$$$$$   /$$$$$$$  /$$$$$$$  /$$$$$$  /$$$$$$$
         /$$_____/| $$__  $$|_  $$_/   |____  $$ /$$__  $$ /$$__  $$ /$$_____/ /$$_____/ |____  $$| $$__  $$
        |  $$$$$$ | $$  \ $$  | $$      /$$$$$$$| $$  \__/| $$  \ $$|  $$$$$$ | $$        /$$$$$$$| $$  \ $$
         \____  $$| $$  | $$  | $$ /$$ /$$__  $$| $$      | $$  | $$ \____  $$| $$       /$$__  $$| $$  | $$
         /$$$$$$$/| $$  | $$  |  $$$$/|  $$$$$$$| $$      |  $$$$$$/ /$$$$$$$/|  $$$$$$$|  $$$$$$$| $$  | $$
        |_______/ |__/  |__/   \___/   \_______/|__/       \______/ |_______/  \_______/ \_______/|__/  |__/
        """);
}