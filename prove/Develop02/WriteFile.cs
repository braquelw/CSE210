using System.IO;

string fileName = "myJournal.txt";

using (StreamWriter outputFile = new StreamWriter(fileName))
{
    // Heading Line of Journal
    outputFile.WriteLine("My Journal");
    outputFile.WriteLine();
    foreach (JournalEntry i in _entries)
    TextWriter.WriteLine(i);
}