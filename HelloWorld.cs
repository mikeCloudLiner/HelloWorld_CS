// Der Namespace System wird importiert, da er die erforderlichen
// Klassen und Methoden für die Konsolenausgabe bereitstellt.
// Alternativ kann System.Console.WriteLine direkt verwendet werden.
using System;

// Ein Namespace ist ein Container für Klassen und andere Typen,
// der Namenskonflikte zwischen gleichnamigen Typen aus
// verschiedenen Bibliotheken oder Programmen verhindert.
// Er dient der strukturierten Code-Organisation und ist in
// komplexen Anwendungen unerlässlich.
namespace HelloWorldApp
{
    // In C# ist eine Klasse die Grundlage jedes Programms.
    // Üblicherweise enthält die Program-Klasse den Einstiegspunkt
    // des Programms, die Main-Methode. Diese Struktur ist
    // erforderlich, da jedes C#-Programm mindestens eine Klasse
    // benötigt.
    // In C# gibt es verschiedene Sichtbarkeiten für Klassen.
    // Eine public-Klasse ist für alle sichtbar und zugänglich.
    // Die Sichtbarkeit private gilt nur für verschachtelte Klassen
    // und macht sie ausschließlich innerhalb der umschließenden
    // Klasse nutzbar. Die protected-Sichtbarkeit betrifft ebenfalls
    // verschachtelte Klassen und erlaubt den Zugriff innerhalb der
    // umschließenden Klasse sowie deren Unterklassen.
    // Eine Klasse in C# wird mit dem Schlüsselwort class deklariert.
    // Der Name der Klasse muss nicht zwingend mit dem Dateinamen
    // übereinstimmen, es ist jedoch eine bewährte Praxis,
    // den Dateinamen entsprechend dem Klassennamen zu wählen.
    public class HelloWorld
    {
        // Die Main-Methode ist der Einstiegspunkt eines jeden
        // C#-Programms. Sie ist als static deklariert, sodass
        // sie ohne Instanz der Klasse aufgerufen werden kann.
        // Der Rückgabewert ist void, da die Methode keinen Wert
        // zurückgibt. Der Parameter string[] args ermöglicht
        // die Übergabe von Kommandozeilenargumenten, wird aber
        // nicht zwingend genutzt. Die Main-Methode ist essenziell,
        // da jede C#-Anwendung mit ihrer Ausführung beginnt.
        public static void Main(string[] args)
        {
            // Die Methode Console.WriteLine() gibt den Text
            // "Hello World!" auf der Konsole aus. Console ist
            // eine Klasse aus dem System-Namespace, die die
            // Interaktion mit der Konsole ermöglicht. Die
            // Methode WriteLine() schreibt eine Zeile Text
            // und fügt automatisch einen Zeilenumbruch hinzu.
            // Sie wird verwendet, um auf einfache Weise Ausgaben
            // an den Benutzer darzustellen. In diesem Fall dient
            // sie dazu, die Nachricht "Hello World!" auszugeben.
            Console.WriteLine("Hello World!");
        }
    }
}